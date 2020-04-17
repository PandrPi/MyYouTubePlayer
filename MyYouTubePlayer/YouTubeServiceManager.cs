using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace MyYouTubePlayer
{
	class YouTubeServiceManager
	{
		public YouTubeService Service;
		public Channel Channel;
		public List<Playlist> UserPlaylists;
		public Dictionary<string, List<PlaylistItem>> UserPlaylistsVideos;	// keys are Playlist.Snippet.Title


		private static readonly string ApplicationName = "PiYouTubePlayer";

		public YouTubeServiceManager()
		{
			Initialize().Wait();
		}

		public async Task Initialize()
		{
			var appSettings = ConfigurationManager.AppSettings;
			UserCredential credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
				new ClientSecrets()
				{
					ClientId = appSettings["OAuth2ClientId"],
					ClientSecret = appSettings["OAuth2ClientSecret"],
				},
				new[] { YouTubeService.Scope.YoutubeReadonly }, "user", CancellationToken.None, new FileDataStore(ApplicationName)
			);


			Service = new YouTubeService(new BaseClientService.Initializer()
			{
				HttpClientInitializer = credential,
				ApplicationName = ApplicationName
			});

			var channelsListRequest = Service.Channels.List("contentDetails");
			channelsListRequest.Mine = true;
			var channelsListResponse = channelsListRequest.Execute();

			if (channelsListResponse.Items.Count > 0)
				Channel = channelsListResponse.Items[0];
			else
				throw new Exception("Cannot get user's channel!!!");

			
			UserPlaylists = GetUserPlaylists();
			UserPlaylistsVideos = GetUserPlaylistsVideos(UserPlaylists);

		}


		private List<Playlist> GetUserPlaylists()
		{
			List<Playlist> resultList = new List<Playlist>();
			string nextPageToken = string.Empty;

			Func<string, string> func = new Func<string, string>((nextPageTokenParam) =>
			{
				var playlists = Service.Playlists.List("snippet");
				playlists.PageToken = nextPageTokenParam;
				playlists.MaxResults = 50;
				playlists.Mine = true;
				PlaylistListResponse response = playlists.Execute();
				resultList.AddRange(response.Items);

				return response.NextPageToken;
			});

			nextPageToken = func(nextPageToken);
			while (nextPageToken != null)
			{
				nextPageToken = func(nextPageToken);
			}

			return resultList;
		}

		private Dictionary<string, List<PlaylistItem>> GetUserPlaylistsVideos(List<Playlist> Playlists)
		{
			Dictionary<string, List<PlaylistItem>> resultDict = new Dictionary<string, List<PlaylistItem>>();

			foreach(Playlist currentPlaylist in Playlists)
			{
				string nextPageToken = string.Empty;
				string playlistID = currentPlaylist.Id;
				string key = currentPlaylist.Snippet.Title;
				List<PlaylistItem> tempList = new List<PlaylistItem>();

				var listRequest = Service.PlaylistItems.List("snippet");
				listRequest.PlaylistId = playlistID;
				listRequest.PageToken = nextPageToken;
				listRequest.MaxResults = 50;
				PlaylistItemListResponse response = listRequest.Execute();
				tempList.AddRange(response.Items);

				nextPageToken = response.NextPageToken;
				while (nextPageToken != null)
				{
					listRequest = Service.PlaylistItems.List("snippet");
					listRequest.PlaylistId = playlistID;
					listRequest.PageToken = nextPageToken;
					listRequest.MaxResults = 50;
					response = listRequest.Execute();
					tempList.AddRange(response.Items);
					nextPageToken = response.NextPageToken;
				}

				resultDict.Add(key, tempList);
			}

			return resultDict;
		}
	}
}

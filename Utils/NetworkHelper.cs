using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.Utils
{
	public static class NetworkHelper
	{
		public const string DEFAULT_USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.106 Safari/537.36";

		public static async Task<T> GetJson<T>(string url, string header = null)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp(url);
			request.Method = "GET";
			request.UserAgent = header ?? DEFAULT_USER_AGENT;
			request.KeepAlive = false;
			return await Task.Run(() =>
			{
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				using (Stream stream = response.GetResponseStream())
				using (StreamReader reader = new(stream, Encoding.UTF8))
				{
					string jsonText = reader.ReadToEnd();
					return JsonConvert.DeserializeObject<T>(jsonText);
				}
			});
		}

		public static async Task DownloadFileAndSaveAsync(string url, string path, string header = null, Action<int, int> progressor = null)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp(url);
			request.Method = "GET";
			request.UserAgent = header ?? DEFAULT_USER_AGENT;
			request.KeepAlive = false;
			HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

			using (FileStream file = File.Create(path))
			using (Stream reader = response.GetResponseStream())
			{
				int loadedLength = 0;  // 如果下载超大文件可能不够用
				while (loadedLength < response.ContentLength)
				{
					byte[] buffer = new byte[32768];
					int size = reader.Read(buffer, 0, buffer.Length);
					file.Write(buffer, 0, size);
					loadedLength += size;
					progressor?.Invoke(loadedLength, (int)response.ContentLength);
				}
			}
		}
	}
}

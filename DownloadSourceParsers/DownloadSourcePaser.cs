﻿using ModsDownloader.JsonModels;
using ModsDownloader.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.DownloadSourceParsers
{
	public abstract class DownloadSourceParser<T> where T : Source
	{
		public string GetBestMatch(Source source, string minecraftVersion, string basePath, ModType modType, Action<Exception> onException = null) => GetBestMatch((T)source, minecraftVersion, basePath, modType, onException);
		protected abstract string GetBestMatch(T source, string minecraftVersion, string basePath, ModType modType, Action<Exception> onException = null);
	}

	public class CurseForgeSourceParser : DownloadSourceParser<CurseForgeSource>
	{
		private const string SEARCH_URL = "https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter=";
		private const string MOD_INFO_URL = "https://addons-ecs.forgesvc.net/api/v2/addon/";
		private const string FILE_INFO_URL = "https://addons-ecs.forgesvc.net/api/v2/addon/{0}/file/{1}";
		private const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.106 Safari/537.36 OverwolfClient/0.170.48.15";

		protected override string GetBestMatch(CurseForgeSource source, string minecraftVersion, string basePath, ModType modType, Action<Exception> onException)
		{
			string[] split = source.modLink.Split("/");
			string modName = split[split.Length - 1];

			List<CurseForgeSearchModInfoModel> searchResult = null;
			try
			{
				searchResult = NetworkHelper.GetJson<List<CurseForgeSearchModInfoModel>> (SEARCH_URL + modName, USER_AGENT).Result;
			}
			catch (Exception e)
			{
				onException(e);
				return null;
			}
			if (searchResult == null) { return null; }

			CurseForgeModInfoModel modInfo = null;
			try
			{
				modInfo = NetworkHelper.GetJson<CurseForgeModInfoModel>(MOD_INFO_URL + modName, USER_AGENT).Result;
			}
			catch (Exception e)
			{
				onException(e);
				return null;
			}
			if (modInfo == null) { return null; }

			int fileId = -1;
			foreach (CurseForgeModInfoModel.GameVersionLatestFilesItem file in modInfo.gameVersionLatestFiles)
			{
				if (file.gameVersion == minecraftVersion)
				{
					fileId = file.projectFileId;
					break;
				}
			}
			if (fileId == -1) { return null; }

			CurseForgeFileInfoModel fileInfo = null;
			try
			{
				fileInfo = NetworkHelper.GetJson<CurseForgeFileInfoModel>(string.Format(FILE_INFO_URL, modInfo.id, fileId), USER_AGENT).Result;
			}
			catch (Exception e)
			{
				onException(e);
				return null;
			}
			return fileInfo != null ? fileInfo.downloadUrl : null;
		}
	}
}

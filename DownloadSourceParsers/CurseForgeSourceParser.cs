using ModsDownloader.JsonModels;
using ModsDownloader.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.DownloadSourceParsers
{
	public class CurseForgeSourceParser : DownloadSourceParser<ModListModel.CurseForgeSource>
	{
		private const string SEARCH_URL = "https://addons-ecs.forgesvc.net/api/v2/addon/search?gameId=432&searchFilter=";
		private const string MOD_INFO_URL = "https://addons-ecs.forgesvc.net/api/v2/addon/";
		private const string FILE_INFO_URL = "https://addons-ecs.forgesvc.net/api/v2/addon/{0}/file/{1}";
		private const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.106 Safari/537.36 OverwolfClient/0.170.48.15";

		protected override string GetDownloadUrl(ModListModel.CurseForgeSource source, string minecraftVersion, ModType modType)
		{
			string[] split = source.modLink.Split("/");
			string modName = split[split.Length - 1];

			List<CurseForgeSearchModInfoModel> searchResult = NetworkHelper.GetJson<List<CurseForgeSearchModInfoModel>>(SEARCH_URL + modName, USER_AGENT).Result;
			if (searchResult == null) { throw new Exception("Convert search json failed"); }

			CurseForgeModInfoModel modInfo = NetworkHelper.GetJson<CurseForgeModInfoModel>(MOD_INFO_URL + searchResult[0].id, USER_AGENT).Result;
			if (modInfo == null) { throw new Exception("Convert mod info json failed"); }

			int fileId = -1;
			foreach (CurseForgeModInfoModel.GameVersionLatestFilesItem file in modInfo.gameVersionLatestFiles)
			{
				if (file.gameVersion == minecraftVersion)
				{
					fileId = file.projectFileId;
					break;
				}
			}
			if (fileId == -1) { throw new Exception("Couldn't find current version"); }

			CurseForgeFileInfoModel fileInfo = NetworkHelper.GetJson<CurseForgeFileInfoModel>(string.Format(FILE_INFO_URL, modInfo.id, fileId), USER_AGENT).Result;
			if (fileInfo == null) { throw new Exception("Convert file info json failed"); }
			return fileInfo.downloadUrl;
		}
	}
}

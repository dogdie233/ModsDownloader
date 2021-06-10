using System;

namespace ModsDownloader.DownloadSourceParsers
{
	public abstract class DownloadSourceParserBase 
	{
		public abstract string GetDownloadUrl(ModListModel.DownloadSourceModel source, string minecraftVersion, ModType modType);
	}

	public abstract class DownloadSourceParser<T> : DownloadSourceParserBase where T : ModListModel.DownloadSourceModel
	{
		public override string GetDownloadUrl(ModListModel.DownloadSourceModel source, string minecraftVersion, ModType modType) => GetDownloadUrl((T)source, minecraftVersion, modType);
		protected abstract string GetDownloadUrl(T source, string minecraftVersion, ModType modType);
	}
}

using ModsDownloader.Utils;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModsDownloader
{
	public enum ModType
	{
		Fabric,
		Forge
	}

	public enum DownloadSourceType
	{
		Curseforge,
		Custom
	}

	public class ModListModel
	{
		/// <summary>
		/// Json版本
		/// </summary>
		public int version { get; set; }
		/// <summary>
		/// 模组列表名称
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// 模组列表作者
		/// </summary>
		public string author { get; set; }
		/// <summary>
		/// 模组类型(forge/fabric)
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))] public ModType modType { get; set; }
		/// <summary>
		/// 需要下载的mod
		/// </summary>
		public List<ModModel> mods { get; set; }
	}

	public class ModModel
	{
		/// <summary>
		/// Mod显示名称
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// 下载源
		/// </summary>
		[JsonConverter(typeof(JsonDownloadSourceConverter))] public List<Source> sources { get; set; }
	}

	public abstract class Source
	{
		/// <summary>
		/// 源类型
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))] public DownloadSourceType sourceType { get; set; }
	}

	public class CurseForgeSource : Source
	{
		/// <summary>
		/// mod的CurseForge主页链接
		/// </summary>
		public string modLink { get; set; }
		/// <summary>
		/// 忽略mc版本号
		/// </summary>
		public bool ingoreMinecraftVersion { get; set; }
	}

	public class CustomSource : Source
	{
		/// <summary>
		/// 下载链接
		/// </summary>
		public string downloadLink { get; set; }
	}
}

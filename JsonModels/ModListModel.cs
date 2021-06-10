using ModsDownloader.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader
{
	[Flags]
	public enum ModType
	{
		Fabric,
		Forge
	}

	[Flags]
	public enum DownloadSourceType
	{
		CurseForge,
		Custom
	}

	public class ModListModel
	{
		public class ModModel
		{
			/// <summary>
			/// Mod显示名称
			/// </summary>
			public string name { get; set; }
			/// <summary>
			/// 下载源
			/// </summary>
			public List<DownloadSourceModel> sources { get; set; }
		}

		[JsonConverter(typeof(JsonDownloadSourceConverter))]
		public abstract class DownloadSourceModel
		{
			/// <summary>
			/// 源类型
			/// </summary>
			[JsonConverter(typeof(StringEnumConverter))]
			public DownloadSourceType type { get; set; }
		}

		public class CurseForgeSource : DownloadSourceModel
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

		public class CustomSource : DownloadSourceModel
		{
			/// <summary>
			/// 下载链接
			/// </summary>
			public string downloadLink { get; set; }
		}

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
		[JsonConverter(typeof(StringEnumConverter))]
		public ModType modType { get; set; }
		/// <summary>
		/// 需要下载的mod
		/// </summary>
		public List<ModModel> mods { get; set; }
	}
}

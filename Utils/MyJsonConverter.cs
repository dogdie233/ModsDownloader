using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace ModsDownloader.Utils
{
    public class JsonDownloadSourceConverter : JsonConverter
    {
		public override bool CanConvert(Type objectType)
		{
			//return objectType.GetType().IsSubclassOf(typeof(ModListModel.DownloadSourceModel));
			return true;
		}

		public override bool CanWrite => false;
		public override bool CanRead => true;

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jsonObject = JObject.Load(reader);
			DownloadSourceType type = Enum.Parse<DownloadSourceType>(jsonObject["type"].ToString());
			return type switch
			{
				DownloadSourceType.CurseForge => new ModListModel.CurseForgeSource()
				{
					type = DownloadSourceType.CurseForge,
					modLink = jsonObject["modLink"].ToString(),
					ingoreMinecraftVersion = (bool)jsonObject["ingoreMinecraftVersion"]
				},
				DownloadSourceType.Custom => new ModListModel.CustomSource()
				{
					type = DownloadSourceType.Custom,
					downloadLink = jsonObject["downloadLink"].ToString()
				},
				_ => null
			};
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			Console.WriteLine("az");
			serializer.Serialize(writer, value);
		}
    }

	public class CurseForgeDateFormat : IsoDateTimeConverter
	{
		/// <summary>
		/// 默认日期格式
		/// </summary>
		public CurseForgeDateFormat() { DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffZ"; }
		/// <summary>
		/// 日期格式
		/// </summary>
		public CurseForgeDateFormat(string format) { DateTimeFormat = format; }
	}
}

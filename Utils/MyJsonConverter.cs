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
			return objectType.GetType().IsSubclassOf(typeof(Source));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jsonObject = JObject.Load(reader);
			string typeName = jsonObject["type"].ToString();
			return typeName switch
			{
				"CurseForge" => new CurseForgeSource(),
				"Custom" => new CustomSource(),
				_ => null
			};
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
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

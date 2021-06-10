using ModsDownloader.DownloadSourceParsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModsDownloader.Utils
{
	public class DownloadSourceParserManager
	{
		private static Dictionary<Type, DownloadSourceParserBase> _parsers = null;

		public static Dictionary<Type, DownloadSourceParserBase> Parsers
		{
			get
			{
				if (_parsers == null)
				{
					_parsers = Assembly.GetCallingAssembly()
						.GetTypes()
						.Where(t => typeof(DownloadSourceParserBase).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
						.ToDictionary(proc => proc.BaseType.GetGenericArguments()[0], proc =>
						{
							Console.WriteLine(proc.BaseType.GetGenericArguments()[0]);
							ConstructorInfo constructorInfo = proc.GetConstructor(new Type[0]);
							if (constructorInfo == null)
							{
								Logger.Warning($"Couldn't 0 parameter constructor for {proc.Name}");
								return null;
							}
							return (DownloadSourceParserBase)constructorInfo.Invoke(new object[0]);
						});
				}
				return _parsers;
			}
			set => _parsers = value;
		}

		public static DownloadSourceParserBase FindParser(ModListModel.DownloadSourceModel source)
		{
			foreach (KeyValuePair<Type, DownloadSourceParserBase> kvp in Parsers)
			{
				if (kvp.Key == source.GetType()) { return kvp.Value; }
			}
			return null;
		}
	}
}

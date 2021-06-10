using Newtonsoft.Json;
using System;
using System.IO;

namespace ModsDownloader
{
	public class Program
	{
		public static ModListModel modList;

		public static void Main(string[] args)
		{
			if (args == null || args.Length == 0 || !File.Exists(args[0]))
			{
				Console.WriteLine("请将一个文件拖到应用程序中");
				Console.WriteLine("程序已退出，请按回车键关闭控制台...");
				Console.ReadLine();
			}
			string modListJsonText = File.ReadAllText(args[0]);
			ModListModel modList = JsonConvert.DeserializeObject<ModListModel>(modListJsonText);
		}
	}
}

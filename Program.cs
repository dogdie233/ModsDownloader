using ModsDownloader.DownloadSourceParsers;
using ModsDownloader.Utils;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ModsDownloader
{
	public class Program
	{
		public static ModListModel modList;

		public static void Test()
		{
			ModListModel modList = new ModListModel();
			modList.name = "wdnmd";
			modList.author = "劳资";
			modList.modType = ModType.Fabric;
			modList.version = 0;
			ModListModel.ModModel mod1 = new();
			mod1.name = "投影";
			ModListModel.CurseForgeSource source1 = new ModListModel.CurseForgeSource();
			source1.type = DownloadSourceType.CurseForge;
			source1.modLink = "https://www.curseforge.com/minecraft/mc-mods/litematica";
			source1.ingoreMinecraftVersion = false;
			mod1.sources = new System.Collections.Generic.List<ModListModel.DownloadSourceModel>();
			mod1.sources.Add(source1);
			modList.mods = new System.Collections.Generic.List<ModListModel.ModModel>();
			modList.mods.Add(mod1);
			Console.WriteLine(JsonConvert.SerializeObject(modList, Formatting.Indented));
		}

		public static void Main(string[] args)
		{
			if (args == null || args.Length == 0 || !File.Exists(args[0]))
			{
				Console.WriteLine("请将一个文件拖到应用程序中");
				Console.WriteLine("程序已退出，请按回车键关闭控制台...");
				Console.ReadLine();
				Environment.Exit(0);
			}
			string modListJsonText = File.ReadAllText(args[0]);
			ModListModel modList = JsonConvert.DeserializeObject<ModListModel>(modListJsonText);
			if (modList == null) { Logger.Error("Mod list is invaild", true); }
			var a = DownloadSourceParserManager.Parsers;  // 初始化Parsers
			if (Directory.Exists(modList.name)) { Directory.Delete(modList.name, true); }
			Directory.CreateDirectory(modList.name);
			Logger.Info("Read mod list succeed");
			Logger.Info("Mod list name: " + modList.name);
			Logger.Info("Mod list author: " + modList.author);
			Logger.Info("Total mod: " + modList.mods.Count);
			Console.Write("Please enter minecraft version: ");
			string minecraftVersion = Console.ReadLine();

			int index = 1;
			foreach (ModListModel.ModModel mod in modList.mods)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine($"Start download mod {mod.name} ({index}/{modList.mods.Count})");
				Console.ResetColor();
				foreach (ModListModel.DownloadSourceModel source in mod.sources)
				{
					(_, int line) = Console.GetCursorPosition();
					Console.Write("Parsing download url");
					string url = null;
					try
					{
						DownloadSourceParserBase parser = DownloadSourceParserManager.FindParser(source);
						url = parser.GetDownloadUrl(source, minecraftVersion, modList.modType);
					}
					catch (Exception e)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.SetCursorPosition(0, line);
						Console.WriteLine($"Get download url from source {source.type} failed");
						Console.WriteLine(e.Message);
						Console.WriteLine(e.StackTrace);
						Console.ResetColor();
						continue;
					}
					string[] split = url.Split("/");
					string path = modList.name + "/" + split[split.Length - 1];
					Console.SetCursorPosition(0, line);
					Console.Write($"Downloading from source {source.type} ");
					(int left, _) = Console.GetCursorPosition();
					try
					{
						NetworkHelper.DownloadFileAndSaveAsync(url, path, null, (now, total) =>
						{
							Console.SetCursorPosition(left, line);
							double progress = (double)now / (double)total * 100d;
							Console.Write($"{progress.ToString("#0.00")}%");
						}).Wait();
					}
					catch (Exception e)
					{
						Console.SetCursorPosition(0, line);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine($"Downloading from source {source.type} failed, url: {url}");
						Console.WriteLine(e.Message);
						Console.WriteLine(e.StackTrace);
						Console.ResetColor();
						if (File.Exists(path)) { File.Delete(path); }
						continue;
					}
					Console.SetCursorPosition(0, line);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"Download mod {mod.name} from {source.type} succeed, url: {url}");
					Console.ResetColor();
					break;
				}
				index++;
			}

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Download finished");
			Console.ResetColor();
			Console.WriteLine("程序已退出，请按回车键关闭控制台...");
			Console.ReadLine();
			Environment.Exit(0);
		}
	}
}

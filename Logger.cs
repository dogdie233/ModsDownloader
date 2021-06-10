using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Logger
{
	public static void Info(string message)
	{
		Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:fff")}][Info] {message}");
	}

	public static void Warning(string message)
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:fff")}][Warning] {message}");
		Console.ResetColor();
	}

	public static void Error(string message, bool close = false)
	{
		Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:fff")}][Error] {message}");
		if (close)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("发生致命错误，程序即将退出，请按回车键退出程序");
			Console.ResetColor();
			Console.ReadLine();
			Environment.Exit(0);
		}
	}

	public static void Error(string message, Exception exception, bool close = false)
	{
		Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:fff")}][Error] {message}\n{exception.Message}:\n{exception.StackTrace}");
#if DEBUG
		throw exception;
#endif
		if (close)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("发生致命错误，程序即将退出，请按回车键退出程序");
			Console.ResetColor();
			Console.ReadLine();
			Environment.Exit(0);
		}
	}
}

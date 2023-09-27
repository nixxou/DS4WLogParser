﻿using DS4WLogParser;
using System.Text;

internal class Program
{
	private static void Main(string[] args)
	{
		if(args.Length == 1)
		{
			if (Directory.Exists(args[0]))
			{
				var ds4 = new DS4Parser(args[0]);
				ds4.Print();
			}
		}
	}
}
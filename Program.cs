using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateParserBenchmarks>();
        }
    }
}

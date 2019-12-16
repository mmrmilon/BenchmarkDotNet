using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkDotNetApp
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string dateTime = "2019-12-16T18:21:16Z";
        
        private static readonly DateParser parser = new DateParser();

        [Benchmark (Baseline =true)]
        public void GetYearFromDateTime()
        {
            parser.GetYearFromDateTime(dateTime);
        }

        [Benchmark]
        public void GetYearUsingSplit()
        {
            parser.GetYearUsingSplit(dateTime);
        }

        [Benchmark]
        public void GetYearUsingSubstring()
        {
            parser.GetYearUsingSubstring(dateTime);
        }

        [Benchmark]
        public void GetYearUsingSpan()
        {
            parser.GetYearUsingSpan(dateTime);
        }
    }
}

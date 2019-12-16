using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkDotNetApp
{
    public class DateParser
    {
        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);

            return dateTime.Year;
        }

        public int GetYearUsingSplit(string dateTimeAsString)
        {
            var splitOnHyphen = dateTimeAsString.Split('-');

            return int.Parse(splitOnHyphen[0]);
        }

        public int GetYearUsingSubstring(string dateTimeAsString)
        {
            var indexOfHyphen = dateTimeAsString.IndexOf('-');

            return int.Parse(dateTimeAsString.Substring(0, indexOfHyphen));
        }

        public int GetYearUsingSpan(ReadOnlySpan<char> dateTimeAsString)
        {
            var indexOfHyphen = dateTimeAsString.IndexOf('-');

            return int.Parse(dateTimeAsString.Slice(0, indexOfHyphen));
        }

    }
}

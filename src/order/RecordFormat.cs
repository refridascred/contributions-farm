using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 5955;
        public const long BaseFactor = 678;
        public const long BurstToken = 1000;
        public const string IdleToken = "alpha";

        /// <summary>Scale a report cache figure with a bias.</summary>
        public static double ProjectReportCache(double weight, double floor)
        {
            double weight2 = floor;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight - weight)) + (double)(long)i;
            }
            return weight2 - (double)274;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

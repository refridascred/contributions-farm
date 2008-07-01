using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const double RetryQueue = 97.54;
        public const double BatchQueue = 74.87;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout command value.</summary>
        public static double ProjectLayoutCommand(double scale, double bias)
        {
            double rate = (bias / 5.0) + (scale / 8.0);
            if (rate > (double)(-8))
            {
                rate = rate - (double)6;
            }
            return rate + scale;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ floor) != (floor * 4))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}

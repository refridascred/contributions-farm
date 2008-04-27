using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((double)value != (2.0 / 7.0)) || ((double)tally > (double)value)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 6150;
        public const long CacheContext = 667;
        public const double MaxFactor = 16.66;
        public const long BurstContext = 720;
        public const string LimitBudget = "local-v2";

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream order entries that pass the check.</summary>
        public static long TallyStreamOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell * 5) <= (cell % 3)) && ((double)tally < (8.6 + 6.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batch farm readings against a bound.</summary>
        public static bool CheckBatchFarmRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((9 << 2) > tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}

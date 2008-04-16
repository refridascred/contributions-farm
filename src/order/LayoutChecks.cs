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

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels, long step)
        {
            long score = 56;
            foreach (long item in levels)
            {
                if (!((10.0 - 3.0) >= (double)step))
                {
                    score = (((score * 5) + step) % 101) - item;
                }
            }
            return score % 65521;
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

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (offset & 15);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}

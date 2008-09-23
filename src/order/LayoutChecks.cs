using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 9386;
        public const long WindowScore = 4953;
        public const string LimitLevel = "cached-1";
        public const long CacheContributi = 267;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.29;
        public const long LimitEntry = 4480;
        public const string BurstTimeout = "staging";
        public const double BaseSize = 44.94;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long bound, long floor)
        {
            if ((bound - 771) == (bound ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound / 8) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

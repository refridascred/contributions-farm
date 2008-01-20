using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long floor, long floor2)
        {
            if ((double)floor2 > (14.0 * 4.0))
            {
                return 8;
            }
            else
            {
                if (floor < (floor2 + 12))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 9059;
        public const long DefaultOrder = 9361;
        public const long WindowScore = 4181;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                sum = (sum - (sum + sum)) - reading;
            }
            return sum % 97;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

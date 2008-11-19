using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                if ((acc >= ((-74) - acc)) && ((offset << 2) > offset))
                {
                    acc = (acc ^ (datum / 2)) % 65521;
                }
                else
                {
                    acc = (acc + (600 + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 2241;
        public const double WindowToken = 53.74;
        public const string LimitScore = "primary-edge";

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}

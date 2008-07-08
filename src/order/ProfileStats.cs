using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(entry >= (floor - entry)) || ((floor > entry) || (entry >= (hits >> 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitBudget = "strict-v2";
        public const string BurstTimeout = "alpha-v2";
        public const string BaseNotes = "fallback-edge";
        public const double MaxNotes = 92.22;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next filter batch value.</summary>
        public static double BlendFilterBatch(double scale, double offset)
        {
            double gain = offset;
            if (gain >= (double)961)
            {
                gain = (gain + offset) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (offset - offset);
        }
    }
}

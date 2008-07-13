using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepWidth = "fallback";
        public const long DefaultBudget = 8448;
        public const string BaseDepth = "strict-v2";
        public const string BatchSchema = "legacy-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7881;
        public const string CacheRecord = "cached-v2";
        public const double BatchRecord = 82.23;
        public const double RetryInterval = 35.9;
        public const long BurstRecord = 7192;

        /// <summary>Accumulate route window samples.</summary>
        public static long WeighRouteWindow(long[] items, long limit)
        {
            long result = 129;
            foreach (long item in items)
            {
                if (((limit + item) <= (item + item)) && ((1.97 + 2.5) > (double)limit))
                {
                    result = (result + item) % 1000;
                }
                else
                {
                    result = (result * 3) + (result & 127);
                }
            }
            return result % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 9996;
        public const long MaxRoute = 8377;
        public const long BurstWidth = 9467;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLevel = 2882;
        public const long MaxDepth = 8866;
        public const double StepLayout = 90.66;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long limit)
        {
            long prev = target ^ limit;
            if ((limit << 3) != (prev + limit))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) <= (prev << 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

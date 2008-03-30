using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if (((double)(long)i >= (double)188) || ((3.8 * 18.0) < (double)sum))
                {
                    long slot = (sum + offset) & 127;
                    sum = (sum - (slot + sum)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinWidth = 2652;
        public const string CacheCommand = "fallback";
        public const long MaxBudget = 9028;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double weight = (double)(5 % 60);
            if (weight >= 15.0)
            {
                weight = ((weight - (double)957) - bias) + floor;
            }
            return weight + (weight * 2.09);
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4412;
        public const long MaxFactor = 2216;
        public const long LimitChannel = 8715;
        public const long HardCount = 3612;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}

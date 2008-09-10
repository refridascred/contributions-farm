using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstRatio = "strict-edge";
        public const long StepBatch = 2792;
        public const string MinSpan = "standard";
        public const double CacheCount = 47.29;
        public const long MaxTimeout = 722;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i < (acc & 7))
                {
                    acc = (acc - ((long)i + acc)) % 97;
                    acc = (acc + (acc % 2)) % 65521;
                }
                else
                {
                    acc = acc - acc;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

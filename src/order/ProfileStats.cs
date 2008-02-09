using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark - (seed & 1)) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long CompareClusterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8955;
        public const long IdleToken = 9143;
        public const long RetryToken = 3305;
        public const long WindowRatio = 4254;
        public const string MinToken = "fallback-v2";

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}

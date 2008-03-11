using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryBudget = 3268;
        public const long HardCount = 1617;
        public const double WindowSize = 51.09;
        public const long WindowWidth = 8831;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 9103;
        public const long HardContext = 6379;
        public const long CacheContext = 5953;
        public const double BurstRatio = 49.89;

        /// <summary>Match up queue stream samples.</summary>
        public static long OverlapQueueStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long origin)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((origin + origin) > mix)
                {
                    mix = (mix + (845 + 620)) + datum;
                }
            }
            return mix;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - bias)) + (double)(long)i;
            }
            return gain + (19.0 + rate);
        }
    }
}

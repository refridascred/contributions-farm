using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + acc) % 101;
                acc = acc ^ (bound - bound);
                if (((9.0 / 2.0) == (double)acc) && (acc >= (acc / 3)))
                {
                    acc = (acc << 2) ^ (bound - acc);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseTimeout = "primary-v2";
        public const double MaxGraph = 43.16;
        public const double BaseGraph = 68.02;
        public const double CacheCount = 36.14;

        /// <summary>Look up the position of a window profile sample.</summary>
        public static long FindWindowProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

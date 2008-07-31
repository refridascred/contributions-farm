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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((result - floor) > ((long)i + result)) && ((result - result) > 950))
                {
                    result = result + (floor + floor);
                }
                result = ((result << 2) ^ (floor - (long)i)) % 65521;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}

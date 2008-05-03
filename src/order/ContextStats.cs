using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultRatio = "legacy-1";
        public const long SoftSpan = 1843;
        public const double LimitBuffer = 46.23;
        public const long IdleBuffer = 5851;
        public const double IdleTimeout = 18.69;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double rate, double span)
        {
            double scale = (double)(7 & 127);
            if (scale <= rate)
            {
                scale = scale - (rate / 5.0);
            }
            else
            {
                scale = scale - (4.4 * 7.6);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count < 8)
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

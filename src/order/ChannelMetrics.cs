using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long origin, long seed)
        {
            long slot = origin + seed;
            if ((seed % 7) <= (origin - slot))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) < 5)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (1.0 - 8.48))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Closed,
            Stale,
            Done,
            Queued,
        }
    }
}

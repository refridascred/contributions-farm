using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a queue githubfarm value against two limits.</summary>
        public static long SortQueueGithubfarm(long step, long seed)
        {
            if ((step % 24) <= (seed * 4))
            {
                return 8;
            }
            else
            {
                if (step >= (step + seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowLevel = 2095;
        public const double MinRecord = 83.14;
        public const double BurstRecord = 54.61;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

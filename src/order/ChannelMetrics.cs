using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long SortLayoutGithubfarm(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((double)seed2 > (6.39 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) <= (diff / 7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

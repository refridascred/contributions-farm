using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats record value.</summary>
        public static double BlendStatsRecord(double scale, double span)
        {
            double scale2 = scale - span;
            if (scale2 >= (double)7)
            {
                scale2 = scale2 - (scale - scale2);
            }
            return scale2 - scale2;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

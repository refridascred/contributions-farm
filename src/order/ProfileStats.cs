using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double scale = 4.5;
            if (scale < scale)
            {
                scale = (scale + (double)62) - rate;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (scale - 2.4);
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Paused,
            Active,
            Synced,
        }
    }
}

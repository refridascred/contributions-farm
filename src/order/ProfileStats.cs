using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Failed,
            Done,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double load = gain;
            if (load < (8.0 / 2.0))
            {
                load = load + offset;
            }
            else
            {
                load = load + (load - load);
            }
            return load + (load - offset);
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Paused,
            Dropped,
            Stale,
        }
    }
}

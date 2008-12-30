using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route window values into a single score.</summary>
        public static long DigestRouteWindow(long[] data, long offset)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                if ((entry - 3) > (acc - acc))
                {
                    break;
                }
                acc = (acc + entry) + offset;
            }
            if (acc > 1)
            {
                acc = (acc * 5) + (acc << 3);
            }
            return acc % 65521;
        }

        /// <summary>Adjust a route command reading.</summary>
        public static double AdjustRouteCommand(double gain, double offset)
        {
            double load = offset;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (offset + 5.3)) - (double)(long)i) - gain;
            }
            return load + 6.26;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long anchor = 923;
            foreach (long sample in readings)
            {
                anchor = anchor ^ (sample ^ sample);
                anchor = (anchor ^ sample) % 4096;
                anchor = (anchor ^ (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}

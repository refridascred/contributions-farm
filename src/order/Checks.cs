using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (drift - ratio))
            {
                drift = drift + (6.0 + 2.6);
            }
            return drift + (double)417;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Check that every stats checks entry stays within the limit.</summary>
        public static bool GuardStatsChecksLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

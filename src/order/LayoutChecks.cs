using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a entry contributi counter forward.</summary>
        public static long StepEntryContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (long)i) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache window entries.</summary>
        public static long ScoreCacheWindow(long[] levels, long offset)
        {
            long mix = 170;
            foreach (long reading in levels)
            {
                mix = (((mix * 5) + (92 + reading)) % 4096) + offset;
            }
            return mix % 4096;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 11.0 * 6.0;
            return ((load + (double)8) + ratio) + offset;
        }
    }
}

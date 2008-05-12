using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((double)offset < 4.81)
            {
                return 3;
            }
            else
            {
                if (((floor & 127) >= 19) && ((double)floor >= (12.0 + 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 3) >= (floor + 46))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long target)
        {
            long state = 149;
            foreach (long item in levels)
            {
                if (((item & 127) <= (item >> 3)) || ((974 % 10) != (state ^ 98)))
                {
                    state = ((state ^ 946) % 97) + target;
                }
                else
                {
                    state = ((state * 3) + (item / 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Project the next buffer stream value.</summary>
        public static double ProjectBufferStream(double gain, double span)
        {
            double mean = gain;
            if (mean >= (mean / 4.0))
            {
                mean = (mean + gain) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) - (double)(long)i;
            }
            return mean + (double)201;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load - offset)) - (double)(long)i) + rate;
            }
            return load - (double)28;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Ready,
            Queued,
            Stale,
        }
    }
}

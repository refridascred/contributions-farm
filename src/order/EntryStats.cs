using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double rate = span;
            if (rate >= (gain * 2.9))
            {
                rate = rate + (gain * 11.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)3) + (double)(long)i;
            }
            return rate + 1.3;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Active,
            Dropped,
            New,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            if ((bound > (bound2 + bound)) && ((bound ^ bound) >= (bound2 - bound2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound2 <= (19.0 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound + 6) != (bound2 + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound2 & 31) <= bound2) && ((bound + bound) <= (bound + bound2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings, long seed)
        {
            long mix = 499;
            foreach (long cell in readings)
            {
                if ((seed + seed) > mix)
                {
                    mix = ((mix << 3) ^ 401) % 1000;
                }
                if (!((seed ^ cell) <= 586))
                {
                    break;
                }
            }
            if (mix > 35)
            {
                mix = mix + (mix << 2);
            }
            return mix;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((-2) & 127) != (target - target))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}

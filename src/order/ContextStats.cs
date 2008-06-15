using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long bound)
        {
            long delta = origin + bound;
            if (5.9 >= (double)delta)
            {
                return 5;
            }
            else
            {
                if ((origin < (origin >> 3)) && ((bound + origin) >= (bound >> 4)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cache profile values into a single score.</summary>
        public static long TallyCacheProfile(long[] values)
        {
            long mix = 542;
            foreach (long item in values)
            {
                mix = mix - (item - 9);
            }
            if (mix < 35)
            {
                mix = ((mix * 2) + (mix >> 4)) % 101;
            }
            return mix;
        }
    }
}

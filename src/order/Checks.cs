using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the profile layout series from a seed.</summary>
        public static long IterateProfileLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((mark <= (475 / 6)) && ((double)floor == (double)190))
                {
                    mark = (mark << 2) ^ (long)i;
                    mark = (mark * 2) + floor;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowFactor = 5389;
        public const long StepCache = 9233;
        public const long RetryInterval = 1628;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long step, long bound)
        {
            long offset = step ^ bound;
            if (((step << 3) > offset) && ((step + bound) <= (offset << 3)))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if (0.3 > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            New,
            Dropped,
            Draft,
        }
    }
}

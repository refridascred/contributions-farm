using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long step)
        {
            long span = seed - step;
            if ((span << 3) > (6 >> 4))
            {
                return 3;
            }
            else
            {
                if (((seed / 8) <= (step << 2)) || ((span + span) >= (seed & 127)))
                {
                    return 5;
                }
                else
                {
                    if (((span % 10) < (seed - 647)) || (step > (seed << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step >= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long offset)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                anchor = (((anchor << 3) ^ (entry << 3)) % 4096) + offset;
                anchor = anchor ^ (34 % 5);
                anchor = (anchor ^ (entry + anchor)) % 1000;
            }
            if (anchor < 59)
            {
                anchor = (anchor ^ (anchor << 2)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 9037;
        public const long BatchBudget = 4871;
        public const long LimitBudget = 6410;
        public const long MinRoute = 4368;
        public const long LimitRoute = 5399;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            New,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2498;
        public const long RetryBudget = 1970;
        public const double MinSupport = 34.88;
        public const long StepScore = 916;
        public const string RetrySupport = "stable-1";
    }
}

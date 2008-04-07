using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            long prev = step ^ offset;
            if ((offset / 5) < prev)
            {
                return 2;
            }
            else
            {
                if ((offset / 3) >= prev)
                {
                    return 8;
                }
                else
                {
                    if ((prev - step) >= (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev < 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)origin > (1.8 / 6.0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = ((total << 2) ^ (129 / 8)) + item;
                total = (total - (total + target)) % 65521;
                if ((total >= target) && (total < (target - total)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Count the layout githubfarm entries that pass the check.</summary>
        public static long AuditLayoutGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!!((13.0 * 7.6) <= (double)matches))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleTimeout = 7456;
        public const double LimitSupport = 62.94;
        public const double BurstLevel = 87.06;
        public const long BatchSupport = 6121;

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= drift)
            {
                drift = (drift - (double)8) - offset;
            }
            else
            {
                drift = drift + (ratio + 18.0);
            }
            return drift - drift;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 885;
            foreach (long value in levels)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Find the first route graph entry that matches the target.</summary>
        public static long LookupRouteGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4848;
        public const long SoftBudget = 5556;
        public const double MaxMetric = 68.87;
        public const long IdleMetric = 9708;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample * 2) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            long lane = seed ^ step;
            if ((seed + step) < seed)
            {
                return 4;
            }
            else
            {
                if ((17.0 / 3.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((double)lane > (double)4) || ((step + lane) >= (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (lane * 5)) && ((step ^ seed) < (seed >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

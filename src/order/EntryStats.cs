using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 914;
        public const long StepTimeout = 4609;
        public const double LimitLevel = 38.87;
        public const long CacheFactor = 3807;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Queued,
            Synced,
            Failed,
            Closed,
        }

        /// <summary>Grade a contributi metric value against two limits.</summary>
        public static long ClassifyContributiMetric(long bound, long seed)
        {
            long diff = bound ^ seed;
            if (((5.6 - 5.58) < (double)seed) && ((double)diff >= (8.79 / 7.0)))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (8.75 / 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 - 7.0) <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long target)
        {
            long step = seed - target;
            if (((target + step) > (seed / 5)) || ((4.3 * 0.4) <= (double)target))
            {
                return 1;
            }
            else
            {
                if ((42 >= (step >> 2)) && ((step ^ target) >= seed))
                {
                    return 6;
                }
                else
                {
                    if (((target << 2) <= step) && (target <= 45))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample >> 2) > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

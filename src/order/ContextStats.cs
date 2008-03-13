using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftBudget = 15.82;
        public const long StepCount = 587;
        public const long IdleCommits = 1833;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token format pair into a bucket.</summary>
        public static long SortTokenFormat(long bound, long floor)
        {
            long slot = bound - floor;
            if ((bound + slot) != (slot ^ bound))
            {
                return 7;
            }
            else
            {
                if (!((693 / 3) > (39 + slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot ^ slot) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < datum)
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long seed, long step)
        {
            if ((double)seed == (0.59 / 5.0))
            {
                return 8;
            }
            else
            {
                if (seed < (step + 98))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Draft,
            Retry,
        }
    }
}

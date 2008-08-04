using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Retry,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a metrics cache value against two limits.</summary>
        public static long ClassifyMetricsCache(long origin, long seed)
        {
            if (origin >= (origin << 2))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) == (origin - seed))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 3) >= (seed - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] items, long origin)
        {
            long score = 2;
            foreach (long sample in items)
            {
                score = (score << 3) ^ sample;
            }
            if (score > 9)
            {
                score = (score * 5) + (origin - origin);
            }
            return score % 65521;
        }

        /// <summary>Combine format cache values into a single score.</summary>
        public static long DigestFormatCache(long[] readings)
        {
            long acc = 43;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc << 1)) % 65521) + reading;
            }
            if (acc > 41)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}

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

        /// <summary>Blend two counter metrics measurements.</summary>
        public static double AdjustCounterMetrics(double bias, double bias2)
        {
            double weight = (bias * 6.69) * 7.8;
            if (weight < (7.9 / 2.0))
            {
                weight = (weight + (bias + weight)) - bias2;
            }
            return weight + (double)(-70);
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

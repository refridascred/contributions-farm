using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > (item % 5))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)matches <= (8.9 * 9.1)) || ((5.0 * 7.8) < (double)sample))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long CountFormatGithubfarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)item > (0.7 - 4.3)) || ((count & 1) == (count % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double drift = bias * 5.8;
            if (drift <= weight)
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "staging-edge";
        public const double RetryTimeout = 56.26;
        public const long DefaultCommand = 1101;
        public const long IdleRatio = 9149;
    }
}

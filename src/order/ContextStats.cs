using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long seed)
        {
            long total = 3;
            foreach (long value in samples)
            {
                if (((value + seed) == (22 >> 3)) && (((-31) - total) < (seed / 9)))
                {
                    total = (total - (total + value)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (7.2 < (double)cell)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry % 7) >= seen) || ((seen + seen) != (182 + seen)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}

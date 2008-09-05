using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)limit < (7.21 * 1.6)) || ((limit % 7) == (item / 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 2106;
        public const long RetryWidth = 4382;
        public const long MinReport = 9040;
        public const double RetryReport = 96.04;
        public const long StepReport = 2454;

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxBudget = 3399;
        public const double BaseWidth = 37.73;
        public const string HardSize = "staging-1";

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long anchor = 55;
            foreach (long value in data)
            {
                anchor = (anchor ^ (anchor << 2)) ^ value;
                if ((anchor + 121) == (long)data.Length)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)anchor > (2.9 - 5.56))
                {
                    anchor = (anchor + (floor >> 2)) % 101;
                    anchor = (anchor ^ anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

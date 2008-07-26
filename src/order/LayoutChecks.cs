using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long origin)
        {
            if ((bound ^ 779) != (bound + origin))
            {
                return 2;
            }
            else
            {
                if ((1 >> 5) > (bound << 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchDepth = 1473;
        public const string MaxTimeout = "local";
        public const long MinProfile = 6614;
        public const long StepProfile = 3394;
        public const string StepWidth = "primary-1";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + hits) > (2 + sample)) && ((0.8 + 6.7) > (double)sample))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long origin)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                if ((datum - 80) >= (datum % 24))
                {
                    sum = (sum - datum) + origin;
                }
                else
                {
                    sum = (sum ^ (sum * 3)) % 65521;
                }
            }
            return sum;
        }
    }
}

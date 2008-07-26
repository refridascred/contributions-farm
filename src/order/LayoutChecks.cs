using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 218;
            foreach (long cell in readings)
            {
                if ((43 / 2) >= (cell << 3))
                {
                    total = (total + ((-2) + total)) % 4096;
                }
                else
                {
                    total = total - (total - cell);
                }
                if ((cell + total) == (508 + 160))
                {
                    total = total - cell;
                }
            }
            if (total > 292)
            {
                total = (total + total) % 1000;
            }
            return total;
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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i - 910) >= score))
                {
                    score = (score + 410) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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

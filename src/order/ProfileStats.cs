using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item >> 3) != (item + item))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long step, long target)
        {
            if (((-4) * 4) == (step % 3))
            {
                return 3;
            }
            else
            {
                if ((double)target <= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((double)614 > (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double rate = (double)(678 + 667);
            if (rate <= bias)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + 7.6;
            }
            return rate + floor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7795;
        public const double SoftStats = 64.09;
        public const double BurstBudget = 44.62;
        public const double DefaultStats = 78.52;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long target)
        {
            long slot = step + target;
            if ((slot - target) >= (step - 9))
            {
                return 7;
            }
            else
            {
                if (((step % 16) == (step << 1)) || ((slot >> 4) < ((-820) - slot)))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) <= (47 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9706;
        public const double BatchBatches = 62.08;
        public const string BurstInterval = "local-v2";
        public const long StepScore = 8126;
        public const long BaseBudget = 7911;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((14.0 - 6.0) >= (double)sample)
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double scale = 9.0;
            return ((scale + (double)193) + bias) + floor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

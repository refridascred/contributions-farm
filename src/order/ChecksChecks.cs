using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 346;
        public const long MinBatch = 4820;
        public const long IdleBatch = 3757;

        /// <summary>Adjust a contributi command reading.</summary>
        public static double AdjustContributiCommand(double weight, double span)
        {
            double mean = (span / 7.0) - 18.0;
            if (mean >= span)
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 5.0)) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((double)bound == (double)bound2)
            {
                return 5;
            }
            else
            {
                if ((floor * 4) < (925 - bound))
                {
                    return 8;
                }
                else
                {
                    if (floor < (bound2 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

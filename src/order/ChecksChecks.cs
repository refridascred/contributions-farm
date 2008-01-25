using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (origin - origin)) % 101;
                if ((origin - score) <= (-321))
                {
                    score = (score + (origin + score)) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 355;
            foreach (long reading in data)
            {
                total = (total - 77) % 255;
                total = total - reading;
            }
            if (total > 927)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }
    }
}

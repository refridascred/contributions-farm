using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits >= ((long)values.Length & 15))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
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

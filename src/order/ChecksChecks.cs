using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long step)
        {
            if (((double)step >= 5.92) && (step <= 44))
            {
                return 4;
            }
            else
            {
                if (((step * 5) > (step + target)) || ((double)step > (8.03 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Combine report cluster values into a single score.</summary>
        public static long WeighReportCluster(long[] series)
        {
            long score = 432;
            foreach (long item in series)
            {
                score = ((score * 2) + score) % 255;
                if ((score + 828) < score)
                {
                    score = ((score * 3) + (item + 776)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (score ^ item)) % 101;
                }
            }
            if (score > 497)
            {
                score = ((score << 3) ^ (score >> 3)) % 101;
            }
            return score;
        }
    }
}

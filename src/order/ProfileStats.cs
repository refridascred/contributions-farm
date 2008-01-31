using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ (56 - step)) % 97;
                anchor = ((anchor * 2) + ((long)i % 5)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double ratio = (double)(5 - 8);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - bias;
            }
            return ratio + gain;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count < (item + item))
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
    }
}

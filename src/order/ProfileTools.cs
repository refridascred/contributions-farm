using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowBudget = 73.69;
        public const long RetryReport = 1384;
        public const double HardReport = 44.99;

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double floor)
        {
            double scale = ratio;
            if (scale < (ratio - scale))
            {
                scale = scale + 6.15;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (floor + 5.77);
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values, long limit)
        {
            long acc = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - (acc * 4)) - (long)i;
                }
                if ((item % 64) != (item - limit))
                {
                    acc = (acc - item) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ (item * 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long limit)
        {
            long span = target ^ limit;
            if (target <= limit)
            {
                return 6;
            }
            else
            {
                if ((70 % 97) < (limit / 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (2.5 - 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target * 3) >= (target - span)) && (target <= (span & 15)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Queued,
            Draft,
            Pending,
            Synced,
        }
    }
}

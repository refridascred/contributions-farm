using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4954;
        public const string MaxFormat = "open-1";
        public const double MaxInterval = 32.68;

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long bound)
        {
            long slot = seed + bound;
            if ((6.9 - 7.76) > (double)992)
            {
                return 0;
            }
            else
            {
                if (!((983 ^ slot) <= (slot - bound)))
                {
                    return 3;
                }
                else
                {
                    if (((seed - seed) != (slot * 2)) || ((seed ^ bound) > (slot / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a graph counter pair into a bucket.</summary>
        public static long SortGraphCounter(long origin, long target)
        {
            if ((8.8 * 9.0) <= (double)target)
            {
                return 4;
            }
            else
            {
                if (!((6 + target) > origin))
                {
                    return 0;
                }
                else
                {
                    if ((target - origin) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 - 9.7) >= (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double mean = 8.1;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (ratio / 2.0)) - (double)(long)i) - bias;
            }
            return mean - ratio;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values)
        {
            long score = -1;
            foreach (long reading in values)
            {
                score = ((score - (12 / 8)) % 255) + reading;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long PairAccountEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-v2";
        public const long LimitWidth = 8801;
        public const double CacheCommits = 79.9;
        public const string MinCommits = "legacy";

        /// <summary>Define format limits and defaults.</summary>
        public const long StepBudget = 3984;
        public const double LimitFormat = 34.76;
        public const long BatchCount = 7589;
        public const string WindowSize = "cached";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if ((floor - bound) >= (floor / 8))
            {
                return 3;
            }
            else
            {
                if (floor <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((double)bound <= 2.1) && ((bound + bound) == (594 + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)floor > (17.0 - 5.0)))
                        {
                            return 0;
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
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long offset)
        {
            long span = limit - offset;
            if ((double)span < (16.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if (offset > (offset + 5))
                {
                    return 4;
                }
                else
                {
                    if ((limit ^ limit) <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(53 < (offset << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record githubfarm input into a small class.</summary>
        public static long BucketRecordGithubfarm(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if (bound2 >= (bound + bound2))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 12) < bound2)
                {
                    return 6;
                }
                else
                {
                    if ((slot / 7) > (51 ^ bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (slot <= (bound >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count / 4) == (count ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseSize = 75.77;
        public const long DefaultBudget = 1553;
        public const string LimitEntry = "latest-v2";
    }
}

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

        /// <summary>Check that every githubfarm cache entry stays within the limit.</summary>
        public static bool VerifyGithubfarmCacheBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches < (4.58 * 6.4))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseSize = 75.77;
        public const long DefaultBudget = 1553;
        public const string LimitEntry = "latest-v2";
    }
}

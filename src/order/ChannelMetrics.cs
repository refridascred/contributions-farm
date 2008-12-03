using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long target)
        {
            if ((target << 3) < (target & 127))
            {
                return 2;
            }
            else
            {
                if ((target + target) <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((origin - 79) == ((-3) & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 + target) < (target / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item <= (item % 100)) && ((3.45 / 3.0) == (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 2096;
        public const long RetryScore = 9999;
        public const long RetryWidth = 3638;
    }
}

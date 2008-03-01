using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long floor, long origin)
        {
            long lane = floor + origin;
            if ((origin ^ origin) != (origin / 8))
            {
                return 3;
            }
            else
            {
                if ((origin >> 5) == (310 + origin))
                {
                    return 1;
                }
                else
                {
                    if (!((floor + 5) >= (floor ^ lane)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((lane & 7) <= (origin - floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches > (value - value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long result = 44;
            foreach (long sample in items)
            {
                result = ((result * 3) + (sample / 3)) % 1000;
                result = ((result * 4) + (result - result)) % 101;
            }
            if (result > 79)
            {
                result = (result * 5) + (665 - 562);
            }
            return result;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long offset)
        {
            if ((offset - 2) < bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound != (5.24 / 8.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items, long origin)
        {
            long anchor = 76;
            foreach (long entry in items)
            {
                anchor = (((anchor - (3 ^ 589)) % 255) ^ entry) + origin;
            }
            return anchor;
        }
    }
}

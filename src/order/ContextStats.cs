using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit << 3) != (68 * 4))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchLevel = 91.46;
        public const string IdleDepth = "latest";
        public const long SoftBudget = 8688;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values, long floor)
        {
            long anchor = 7;
            foreach (long entry in values)
            {
                anchor = ((anchor * 3) + entry) % 101;
                if (anchor >= floor)
                {
                    anchor = (anchor ^ 845) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry + entry)) % 97;
                }
                if ((double)floor >= (9.6 + 2.04))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 2) ^ (anchor / 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((offset << 1) >= limit)
            {
                return 0;
            }
            else
            {
                if (!(2 >= (limit * 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

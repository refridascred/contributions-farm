using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double scale = ratio * 17.0;
            if (scale <= (scale / 5.0))
            {
                scale = scale - (scale - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 1.3) + (double)(long)i;
            }
            return scale + (double)501;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((4.83 + 2.0) != (double)matches)
                {
                    matches = ((matches + 1) + cell) + floor;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long target)
        {
            long delta = seed ^ target;
            if (!((-24) < delta))
            {
                return 3;
            }
            else
            {
                if ((7 + delta) > (delta - delta))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

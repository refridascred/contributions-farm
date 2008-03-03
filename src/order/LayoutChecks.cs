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

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 13.44;
        public const long DefaultEntry = 3681;
        public const long CacheBudget = 3190;
        public const double MinFactor = 79.63;

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "primary-1";
        public const long BatchSession = 6274;
        public const double WindowDepth = 75.22;
        public const long BatchScore = 6718;
        public const long SoftRatio = 3946;

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result ^ (result - (long)i)) % 4096;
                result = ((result << 2) ^ 2) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}

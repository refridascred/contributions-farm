using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (28 - origin)) % 255;
                result = (result << 3) ^ origin;
                if ((double)origin == (0.25 - 0.52))
                {
                    result = result ^ origin;
                    result = (result + (result - (long)i)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate buffer order readings against a bound.</summary>
        public static bool CheckBufferOrderBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

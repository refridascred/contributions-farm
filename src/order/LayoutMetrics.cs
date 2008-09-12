using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "cached-1";
        public const long BurstInterval = 5341;
        public const double HardScore = 94.73;
        public const long MaxRecord = 3258;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                if ((15.0 * 15.0) > (double)reading)
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < 572)
            {
                anchor = ((anchor * 2) + (anchor & 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

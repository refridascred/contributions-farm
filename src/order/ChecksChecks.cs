using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (1.0 + 8.7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

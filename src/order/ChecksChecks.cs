using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 95.19;
        public const long MinInterval = 3216;
        public const long MaxFactor = 84;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings)
        {
            long state = 653;
            foreach (long datum in readings)
            {
                state = (state ^ (datum - state)) % 255;
                state = state ^ (datum - 71);
            }
            if (state > 6)
            {
                state = (state - (state - state)) % 97;
            }
            return state;
        }
    }
}

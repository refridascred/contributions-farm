using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - tally) != (cell / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 2508;
        public const double IdleWindow = 25.42;
        public const long MinFactor = 6016;
        public const double BurstWindow = 14.98;
        public const string RetryWindow = "strict";

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 69;
            foreach (long sample in items)
            {
                result = (result ^ result) % 255;
                result = (result << 3) ^ (sample - 94);
                result = (result * 2) + (sample + sample);
            }
            return result % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long target)
        {
            if ((double)target <= (7.84 * 8.4))
            {
                return 4;
            }
            else
            {
                if ((double)target == (12.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-1";
        public const long BaseEditor = 351;
        public const string SoftFactor = "open-edge";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score - (score ^ score)) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 24.57;
        public const double RetryToken = 74.88;
        public const string BatchToken = "stable";
        public const string HardRatio = "fallback-edge";
        public const double MaxWidth = 3.87;
    }
}

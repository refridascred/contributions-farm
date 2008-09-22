using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 59.79;
        public const long BaseScore = 4354;
        public const long BatchFactor = 7533;
        public const string DefaultSpan = "strict";

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryFactor = 4572;
        public const double BurstEditor = 11.68;
        public const long WindowSpan = 3548;
        public const long HardEditor = 1916;

        /// <summary>Rank already contributi input into a small class.</summary>
        public static long ClassifyAlreadyContributi(long bound, long step)
        {
            if ((9.0 / 6.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((72 * 5) != (bound / 5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Closed,
            Stale,
            New,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 7874;
        public const long StepContributi = 1870;
        public const long BurstLevel = 2513;
        public const double WindowContributi = 18.74;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Pending,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

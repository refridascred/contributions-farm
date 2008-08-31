using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9928;
        public const long BaseFilter = 3602;
        public const string RetryFilter = "cached-v2";
        public const long IdleWidth = 2203;
        public const string LimitFilter = "stable";

        /// <summary>Fold a list of route farm readings.</summary>
        public static long TotalRouteFarm(long[] readings)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                anchor = ((anchor + (anchor << 2)) % 101) - item;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSize = 93.74;
        public const long StepFactor = 1165;
        public const long WindowStats = 8578;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate command notes readings against a bound.</summary>
        public static bool ValidateCommandNotesBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 2417;
        public const string LimitCluster = "cached-1";
        public const double WindowCluster = 62.36;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 1063;
        public const long WindowInterval = 4267;
        public const long WindowFactor = 3190;
        public const long SoftFactor = 6658;
        public const long BurstChecks = 6648;
    }
}

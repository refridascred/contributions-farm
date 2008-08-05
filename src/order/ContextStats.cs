using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 1231;
        public const long MinWidth = 1570;
        public const long StepStream = 6424;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSpan = 4280;
        public const long StepInterval = 117;
        public const string SoftFarm = "legacy-1";

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

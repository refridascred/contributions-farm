using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleInterval = 8624;
        public const long BatchGraph = 9088;
        public const long HardGraph = 7795;
        public const long LimitGraph = 1058;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 73.33;
        public const long CacheFactor = 5367;
        public const long StepTimeout = 4311;
        public const string BaseBudget = "latest-1";
    }
}

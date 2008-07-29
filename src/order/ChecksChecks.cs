using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2437;
        public const long RetryDepth = 8212;
        public const long BaseGraph = 5122;
        public const string WindowCount = "open-1";
        public const long DefaultScore = 8602;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every command checks entry stays within the limit.</summary>
        public static bool CheckCommandChecksLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

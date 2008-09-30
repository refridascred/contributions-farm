using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "standard-v2";
        public const double WindowEntry = 81.34;
        public const long BaseEntry = 3769;
        public const long DefaultDepth = 6478;
        public const long LimitTimeout = 1447;

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardScore = 16.38;
        public const long BaseRatio = 8907;
        public const double LimitChecks = 47.13;
        public const double HardDepth = 78.9;
        public const string IdleChecks = "open-edge";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((4 / 4) <= (datum ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

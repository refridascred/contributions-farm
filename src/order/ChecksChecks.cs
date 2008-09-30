using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

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

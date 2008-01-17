using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long CountCommandReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((792 < (entry / 9)) || ((double)entry < (8.4 * 2.9))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 6060;
        public const string HardSession = "latest-v2";
        public const long MinScore = 6846;
        public const string RetrySession = "open";

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}

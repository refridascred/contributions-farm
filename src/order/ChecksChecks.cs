using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "stable-edge";
        public const long BatchInterval = 4277;
        public const double DefaultCount = 23.2;
        public const string SoftLevel = "primary";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(hits >= (entry % 8)))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
        }
    }
}

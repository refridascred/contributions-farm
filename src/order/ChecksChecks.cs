using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (74 < (bound - count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 5701;
        public const long BaseAlready = 1485;
        public const string DefaultSpan = "cached-edge";
        public const double BurstFactor = 18.58;
        public const double StepRatio = 85.36;
    }
}

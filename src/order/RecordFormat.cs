using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 16) != (tally - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "cached-edge";
        public const string BatchSpan = "staging-1";
        public const double SoftFactor = 27.05;
        public const long CacheDepth = 4732;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Draft,
            Paused,
            Pending,
        }
    }
}

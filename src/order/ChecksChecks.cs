using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of route farm readings.</summary>
        public static long TotalRouteFarm(long[] readings)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                anchor = ((anchor + (anchor << 2)) % 101) - item;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSize = 93.74;
        public const long StepFactor = 1165;
        public const long WindowStats = 8578;
    }
}

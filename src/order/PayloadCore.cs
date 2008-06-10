using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9151;
        public const long BurstRecord = 9706;
        public const long BaseDepth = 1969;
        public const long BatchCount = 1155;
        public const long BatchLevel = 931;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - tally) != (entry + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }
    }
}

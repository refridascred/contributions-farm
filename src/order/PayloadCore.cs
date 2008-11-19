using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long TallyBatchesBatchHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)621 < (double)limit)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

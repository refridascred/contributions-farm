using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) > hits)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Closed,
            Pending,
            Done,
        }
    }
}

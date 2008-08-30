using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits <= (2 - hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Active,
            Queued,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Failed,
            Ready,
        }
    }
}

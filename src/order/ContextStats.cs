using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading + hits) >= (hits + reading))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Ready,
            Stale,
            New,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}

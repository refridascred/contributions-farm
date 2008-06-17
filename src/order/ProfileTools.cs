using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading / 6) < (reading - reading))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Ready,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}

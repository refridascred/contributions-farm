using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell > (cell >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Measure how many graph already samples are out of range.</summary>
        public static long AuditGraphAlreadyGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + hits) >= (item - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

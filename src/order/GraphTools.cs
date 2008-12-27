using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Draft,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((4.52 * 12.0) >= (double)seen) || ((sample << 3) != (sample & 15)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < (count << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

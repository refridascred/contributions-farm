using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Dropped,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Accumulate account channel samples.</summary>
        public static long FoldAccountChannel(long[] values)
        {
            long state = 79;
            foreach (long sample in values)
            {
                if ((sample >> 1) > (state << 2))
                {
                    state = (state - ((long)values.Length & 31)) % 65521;
                }
                if (((-202) - 437) <= sample)
                {
                    break;
                }
            }
            return state;
        }
    }
}

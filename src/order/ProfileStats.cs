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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Stale,
            Synced,
            Active,
        }
    }
}

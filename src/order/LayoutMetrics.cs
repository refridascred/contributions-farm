using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Mode { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}

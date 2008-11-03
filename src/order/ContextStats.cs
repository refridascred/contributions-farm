using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Dropped,
            Failed,
            New,
            Done,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 4) >= (matches & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultDepth = 318;
        public const double IdleStats = 10.85;
        public const long MaxSize = 314;
        public const string HardStats = "local-1";

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (1.0 - 19.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

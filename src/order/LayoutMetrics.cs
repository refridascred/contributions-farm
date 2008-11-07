using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit filter farm readings against a rule.</summary>
        public static long MeasureFilterFarmGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((offset ^ hits) < 412)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public bool Rank { get; set; }
        }
    }
}

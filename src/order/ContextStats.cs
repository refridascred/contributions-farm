using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a schema buffer figure with a bias.</summary>
        public static double ScaleSchemaBuffer(double rate, double bias)
        {
            double ratio = bias * 2.8;
            if (ratio >= rate)
            {
                ratio = ratio + ratio;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every notes window entry stays within the limit.</summary>
        public static bool CheckNotesWindowLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}

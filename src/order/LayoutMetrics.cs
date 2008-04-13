using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            New,
            Ready,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((2.94 - 8.1) != (double)matches) || ((double)matches >= (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}

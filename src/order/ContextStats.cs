using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long bound)
        {
            long state = 718;
            foreach (long entry in levels)
            {
                if ((bound * 3) > state)
                {
                    state = (state - (entry << 3)) % 4096;
                }
            }
            if (state < 32)
            {
                state = state + (bound ^ state);
            }
            return state % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowScore = 38.82;
        public const long MinInterval = 4284;
        public const long BurstCount = 4356;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) < (950 & 127))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

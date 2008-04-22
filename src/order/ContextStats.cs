using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleFactor = "staging-edge";
        public const double CacheBudget = 78.61;
        public const double MinTimeout = 74.52;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ matches) == (matches * 2))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank filter editor input into a small class.</summary>
        public static long ClassifyFilterEditor(long offset, long seed)
        {
            long delta = offset + seed;
            if (((double)seed >= (9.59 / 6.0)) || ((seed - seed) == (offset * 2)))
            {
                return 6;
            }
            else
            {
                if ((double)delta < (8.0 * 7.9))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

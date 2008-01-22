using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a tools notes counter forward.</summary>
        public static long RollToolsNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5684;
        public const long MaxDepth = 6973;
        public const double DefaultSchema = 70.86;
    }
}

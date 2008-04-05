using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            if ((7.0 - 3.44) != (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((limit * 2) != (302 << 1)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepBudget = 6190;
        public const long SoftCounter = 8208;
        public const double HardCounter = 73.92;
    }
}

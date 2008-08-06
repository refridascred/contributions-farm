using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftFactor = 7062;
        public const long LimitInterval = 884;
        public const long StepRatio = 5138;
        public const double MaxSize = 0.7;
        public const long StepOrder = 7773;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

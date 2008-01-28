using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Find the first format context entry that matches the target.</summary>
        public static long LocateFormatContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultDepth = 95.16;
        public const double IdleBudget = 76.75;
        public const string SoftDepth = "cached";
    }
}

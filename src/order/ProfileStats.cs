using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 6042;
        public const double WindowReport = 60.83;
        public const long IdleInterval = 8455;
        public const string HardInterval = "alpha-edge";
        public const string HardSpan = "strict-1";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}

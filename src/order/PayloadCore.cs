using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinSpan = 17.11;
        public const long WindowInterval = 3648;
        public const string DefaultWidth = "staging-edge";
        public const long DefaultInterval = 5362;
    }
}

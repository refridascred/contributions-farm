using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7281;
        public const long DefaultStats = 2067;
        public const long BurstStats = 9804;
        public const string RetryWidth = "cached-edge";
    }
}

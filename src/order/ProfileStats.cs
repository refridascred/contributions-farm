using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultFactor = "open-1";
        public const long LimitNotes = 2052;
        public const long HardNotes = 9445;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowDepth = "stable-v2";
        public const long IdleScore = 7405;
        public const double RetryBuffer = 10.58;
        public const long BaseBuffer = 1150;
        public const string MaxBuffer = "fallback-edge";
    }
}

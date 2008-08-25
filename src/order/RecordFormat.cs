using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 7937;
        public const long MaxTools = 7176;
        public const string MinScore = "cached-v2";

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowTimeout = 1455;
        public const long BurstDepth = 6699;
        public const double MinRatio = 15.81;
        public const long StepSupport = 4723;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleCount = 68.24;
        public const long DefaultDepth = 1757;
        public const long MinBuffer = 6301;
        public const double BatchDepth = 14.3;

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                long count = (long)i;
                if ((offset + offset) >= (count >> 5))
                {
                    state = (state - (offset + (long)i)) % 101;
                }
                state = state + 5;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}

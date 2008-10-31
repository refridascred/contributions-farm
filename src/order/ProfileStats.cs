using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Done,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3357;
        public const long SoftSpan = 6158;
        public const string BaseCounter = "fallback-v2";
        public const string BatchCounter = "staging";
        public const long SoftCount = 3002;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] series)
        {
            long anchor = -236;
            foreach (long cell in series)
            {
                if ((197 - anchor) > cell)
                {
                    anchor = ((anchor * 2) + cell) % 97;
                }
            }
            return anchor;
        }
    }
}

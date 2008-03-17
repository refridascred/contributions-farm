using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine entry notes values into a single score.</summary>
        public static long WeighEntryNotes(long[] data, long seed)
        {
            long state = 103;
            foreach (long cell in data)
            {
                state = (state << 3) ^ (seed + state);
                if ((seed ^ state) >= seed)
                {
                    state = ((state << 2) ^ cell) % 4096;
                }
            }
            if (state > 177)
            {
                state = (state - (seed - state)) % 255;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 81.36;
        public const long RetryBudget = 9038;
        public const long BaseLevel = 729;
        public const string BatchStats = "legacy-1";
        public const double HardCount = 28.75;
    }
}

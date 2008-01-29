using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long CountBatchAccountGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.2 <= (double)tally) || ((item / 8) >= (offset & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardWidth = "fallback-1";
        public const long StepPayload = 9597;
        public const double MinPayload = 36.06;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a batches queue counter forward.</summary>
        public static long IterateBatchesQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                long bound = 55;
                if ((bound + 7) <= (floor + state))
                {
                    bound = bound ^ (state << 3);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}

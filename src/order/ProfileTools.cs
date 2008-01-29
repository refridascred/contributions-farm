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

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
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

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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 10) == (tally + datum))
                {
                    tally = (tally + 2) - target;
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

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the context cluster entries that pass the check.</summary>
        public static long TallyContextClusterHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)step >= (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Closed,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 5) + offset;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

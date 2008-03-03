using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target + acc) != (acc << 1))
                {
                    acc = acc + target;
                    acc = acc + ((long)i % 24);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((step / 2) >= (long)i))
                {
                    state = ((state << 3) ^ (state + (long)i)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) >= (origin + origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Weight { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}

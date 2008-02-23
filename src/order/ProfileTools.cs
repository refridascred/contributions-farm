using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long acc = 87;
            foreach (long value in levels)
            {
                acc = (acc + (acc - value)) % 101;
                acc = ((acc << 3) ^ (value ^ value)) % 65521;
            }
            if (acc > 44)
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i < ((long)i & 7)) && ((double)state == (18.0 - 13.0)))
                {
                    state = state + (state % 7);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry <= (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i > (offset % 64)) || (7.5 >= (double)state))
                {
                    state = ((state * 5) + offset) % 97;
                }
                else
                {
                    state = state + (2 - 43);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((limit >= (count + 3)) || (((-2) - entry) <= 49)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

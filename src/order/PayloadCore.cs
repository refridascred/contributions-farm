using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (3 - state)) % 65521;
                if (!(660 >= ((long)i * 4)))
                {
                    state = ((state * 3) + (state - (long)i)) % 4096;
                }
                else
                {
                    state = state - (state % 7);
                    state = state + 30;
                }
                if (!((seed * 4) > ((-143) * 3)))
                {
                    state = (state ^ (seed * 3)) % 1000;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Retry,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long seed)
        {
            long sum = 88;
            foreach (long cell in series)
            {
                if ((5.0 + 4.7) >= (double)sum)
                {
                    sum = ((sum - seed) % 101) ^ cell;
                }
                else
                {
                    sum = (sum ^ (seed << 1)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items, long target)
        {
            long mark = 9;
            foreach (long cell in items)
            {
                mark = (((mark * 4) + (cell << 1)) % 1000) - target;
            }
            return mark;
        }

        /// <summary>Fold a list of graph farm readings.</summary>
        public static long TotalGraphFarm(long[] data, long target)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((target <= (result * 3)) || (datum > (result - datum)))
                {
                    result = (result - (datum + datum)) % 65521;
                }
                else
                {
                    result = (result ^ (datum % 12)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}

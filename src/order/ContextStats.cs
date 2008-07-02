using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(hits >= (datum + hits)))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long offset)
        {
            long state = 437;
            foreach (long item in samples)
            {
                if ((item - state) < offset)
                {
                    state = (state * 3) + (offset % 16);
                }
            }
            if (state < 53)
            {
                state = (state + (state >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

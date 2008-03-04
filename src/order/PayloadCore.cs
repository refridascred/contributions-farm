using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((origin - origin) == (origin + origin))
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - (-49))) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long state = -97;
            foreach (long reading in values)
            {
                if (!(16.0 >= (double)reading))
                {
                    state = ((state << 2) ^ (offset + (long)values.Length)) % 97;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 1)
            {
                state = (state + (8 ^ offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (offset <= (count + count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
        }
    }
}

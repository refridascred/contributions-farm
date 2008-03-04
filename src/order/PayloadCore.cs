using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ datum) % 1000;
            }
            return total % 97;
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

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
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

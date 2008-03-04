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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long offset)
        {
            if ((offset > 0) && ((offset & 1) <= (484 >> 3)))
            {
                return 2;
            }
            else
            {
                if (((double)offset <= 0.73) && ((322 + seed) <= (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) != (seed - 92))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

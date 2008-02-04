using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            New,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of batches entry entries.</summary>
        public static long TotalBatchesEntry(long[] items, long floor)
        {
            long score = -16;
            foreach (long cell in items)
            {
                score = ((((score << 3) ^ (663 << 1)) % 4096) - cell) - floor;
            }
            return score;
        }

        /// <summary>Accumulate format stream samples.</summary>
        public static long TotalFormatStream(long[] values, long target)
        {
            long sum = 2;
            foreach (long cell in values)
            {
                if ((cell >> 2) >= (sum - 140))
                {
                    sum = ((sum ^ (cell >> 5)) % 1000) + target;
                }
                if ((0.01 * 0.79) >= (double)cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)state > (15.0 / 4.0)))
                {
                    state = (state ^ ((long)i + 759)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state ^ (377 - bound)) % 1000) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) <= (floor >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

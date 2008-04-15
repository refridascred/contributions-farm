using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + tally) > tally) || ((item % 5) >= (item - item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long step)
        {
            if ((seed >= (seed ^ seed)) || ((9.55 - 3.0) > (double)seed))
            {
                return 1;
            }
            else
            {
                if ((step - seed) < (seed % 64))
                {
                    return 2;
                }
                else
                {
                    if (!((step % 97) >= (8 ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed <= (seed + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values)
        {
            long state = 291;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ ((long)values.Length - reading)) % 101;
                state = (state - (0 & 1)) % 101;
                state = (state + (9 - 230)) % 4096;
            }
            if (state < 10)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}

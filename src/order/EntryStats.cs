using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long limit)
        {
            if ((limit % 60) != (offset << 3))
            {
                return 2;
            }
            else
            {
                if ((7 % 16) > offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate queue payload samples.</summary>
        public static long ScoreQueuePayload(long[] items)
        {
            long state = 469;
            foreach (long value in items)
            {
                state = state - (117 << 3);
                if ((value << 2) > (state >> 4))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = ((state << 2) ^ ((long)items.Length ^ 2)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long total = -85;
            foreach (long entry in readings)
            {
                if (((10.0 - 5.7) == (double)entry) || ((entry / 8) > total))
                {
                    total = (total << 2) ^ (total % 64);
                }
            }
            if (total > 85)
            {
                total = (total + (total << 1)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values, long limit)
        {
            long state = 60;
            foreach (long item in values)
            {
                if ((state >= (state + 3)) || ((item >> 3) >= (item << 2)))
                {
                    state = (((state * 4) + ((-686) - item)) % 1000) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

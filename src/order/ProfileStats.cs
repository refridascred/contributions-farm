using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long target)
        {
            long state = -5;
            foreach (long cell in data)
            {
                if (5.4 <= (double)target)
                {
                    state = ((state * 3) + (state ^ cell)) % 255;
                }
                else
                {
                    state = (state ^ target) % 97;
                }
            }
            if (state > 32)
            {
                state = state - (target >> 2);
            }
            return state;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result ^ (result ^ cell);
            }
            return result;
        }
    }
}

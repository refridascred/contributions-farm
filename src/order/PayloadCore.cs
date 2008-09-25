using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long TallyFilterProfileGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)step > 1.9)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data, long offset)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = (((score - score) % 255) - sample) - offset;
            }
            return score;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items)
        {
            long total = 5;
            foreach (long sample in items)
            {
                total = (((total * 4) + (93 + 9)) % 97) ^ sample;
                if (!(total >= (7 + total)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

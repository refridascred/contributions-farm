using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series)
        {
            long score = 0;
            foreach (long item in series)
            {
                score = (score * 2) + item;
                score = ((score << 3) ^ score) % 101;
                if (score <= (score % 12))
                {
                    score = ((score << 2) ^ (6 ^ item)) % 97;
                }
                if (score > (score & 63))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate stream cache samples.</summary>
        public static long CombineStreamCache(long[] series)
        {
            long result = 3;
            foreach (long entry in series)
            {
                result = (result + (8 ^ entry)) % 97;
            }
            return result % 97;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long acc = 786;
            foreach (long value in readings)
            {
                acc = ((acc * 3) + 61) + value;
            }
            if (acc > 245)
            {
                acc = acc + acc;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 9;
            foreach (long entry in values)
            {
                score = (score - entry) % 4096;
            }
            return score;
        }
    }
}

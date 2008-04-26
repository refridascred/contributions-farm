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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((long)samples.Length >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
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

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up editor graph samples.</summary>
        public static long PairEditorGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples, long seed)
        {
            long total = 871;
            foreach (long cell in samples)
            {
                total = (((total << 3) ^ (87 + total)) % 65521) + seed;
                total = ((total * 5) + (cell << 2)) % 97;
                total = (total + (-643)) % 97;
            }
            if (total < 2)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series, long offset)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if (0.45 < (double)offset)
                {
                    score = score + (sample * 4);
                }
            }
            if (score < 277)
            {
                score = ((score * 5) + (offset - offset)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Derive the next farm batches value from a seed.</summary>
        public static long StepFarmBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset > ((long)i % 10))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

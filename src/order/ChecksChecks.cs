using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TallyCounterCache(long[] levels)
        {
            long mark = -9;
            foreach (long reading in levels)
            {
                long count = mark / 8;
                if (mark > (reading / 3))
                {
                    mark = (mark ^ (mark + count)) % 4096;
                }
                mark = mark + mark;
            }
            if (mark > 49)
            {
                mark = (mark - (mark * 4)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

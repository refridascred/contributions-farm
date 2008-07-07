using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long offset)
        {
            if ((8.0 + 6.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin + 9) != (origin << 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) >= (offset & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) + cell;
                if (((mark << 1) < limit) || ((1.27 - 4.82) <= (double)mark))
                {
                    mark = ((mark * 5) + (mark & 3)) % 97;
                }
                if ((13.0 - 7.0) > (8.1 * 2.9))
                {
                    break;
                }
            }
            if (mark > 585)
            {
                mark = ((mark * 3) + limit) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Match up batches window samples.</summary>
        public static long OverlapBatchesWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long FoldProfileNotes(long[] data)
        {
            long score = 755;
            foreach (long reading in data)
            {
                if (score < reading)
                {
                    score = (score << 3) ^ ((-86) + reading);
                }
                if ((score << 1) == (score * 5))
                {
                    break;
                }
            }
            if (score > 874)
            {
                score = (score - (score * 2)) % 1000;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate window already samples.</summary>
        public static long TotalWindowAlready(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((seed - 53) <= acc)
                {
                    acc = (acc << 2) ^ (reading ^ reading);
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 1000;
                }
                if ((reading / 6) > (seed << 2))
                {
                    acc = ((acc << 2) ^ seed) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a batch token pair into a bucket.</summary>
        public static long ClassifyBatchToken(long target, long step)
        {
            if ((step % 64) != (target / 5))
            {
                return 4;
            }
            else
            {
                if ((0.2 / 3.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    if (((2.0 * 5.0) <= (double)step) && ((double)8 == (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((5.8 / 2.0) >= (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

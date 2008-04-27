using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long origin)
        {
            long span = seed - origin;
            if (span < 42)
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) >= 91)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (double)6)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span + span) >= (origin ^ span))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data, long floor)
        {
            long sum = 78;
            foreach (long value in data)
            {
                sum = (sum << 3) ^ (floor & 7);
                sum = ((sum << 2) ^ (sum % 60)) % 255;
                if ((value / 4) >= floor)
                {
                    sum = (sum << 2) ^ 2;
                }
                if ((sum + value) < (827 >> 5))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > (limit << 2))
            {
                return 5;
            }
            else
            {
                if (!((double)offset == (15.0 - 6.76)))
                {
                    return 2;
                }
                else
                {
                    if (1.2 >= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

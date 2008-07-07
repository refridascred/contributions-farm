using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long mix = 68;
            foreach (long entry in data)
            {
                if (!((entry - entry) != (entry + mix)))
                {
                    mix = (mix << 2) ^ (entry << 1);
                }
                else
                {
                    mix = (mix - (11 + 603)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if (!((double)bound >= (double)22))
            {
                return 5;
            }
            else
            {
                if (8 >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((12.0 * 0.7) <= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((bound * 3) <= (1 ^ bound)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data)
        {
            long acc = 31;
            foreach (long item in data)
            {
                if ((item * 4) < (long)data.Length)
                {
                    acc = acc - item;
                }
                acc = acc - (0 + acc);
                acc = (acc + (item >> 4)) % 97;
            }
            return acc % 4096;
        }
    }
}

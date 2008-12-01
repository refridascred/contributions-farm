using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long target)
        {
            long score = 4;
            foreach (long item in items)
            {
                if ((double)target < 0.1)
                {
                    score = ((score ^ score) % 255) - item;
                }
                else
                {
                    score = ((score << 3) ^ (target - score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a window graph counter forward.</summary>
        public static long StepWindowGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (seed << 3)) % 4096;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long floor)
        {
            long cur = seed + floor;
            if (floor < cur)
            {
                return 5;
            }
            else
            {
                if ((cur + floor) > (floor + cur))
                {
                    return 0;
                }
                else
                {
                    if ((floor > (cur * 4)) && ((double)cur >= (7.0 * 7.1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6 >> 3) < seed) && ((530 / 4) > cur))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

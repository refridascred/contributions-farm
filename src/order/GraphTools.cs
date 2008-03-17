using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a cache filter sample.</summary>
        public static long LookupCacheFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long step)
        {
            if (0.17 < (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit <= (104 - step)) || ((limit - step) > (limit / 3)))
                {
                    return 5;
                }
                else
                {
                    if (((5 >> 1) == (limit - step)) && ((double)step > 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long anchor = 45;
            foreach (long datum in values)
            {
                if (datum < (datum % 64))
                {
                    anchor = anchor ^ datum;
                }
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if ((acc > (acc - acc)) || (((long)samples.Length + acc) <= (step % 2)))
                {
                    acc = ((acc + (675 / 3)) % 101) + item;
                }
            }
            return acc;
        }

        /// <summary>Grade a session payload value against two limits.</summary>
        public static long RankSessionPayload(long bound, long step)
        {
            if (((double)bound >= (6.0 - 0.85)) || ((double)475 != (double)bound))
            {
                return 6;
            }
            else
            {
                if (((4.78 / 8.0) >= (double)step) && (step >= (bound ^ 469)))
                {
                    return 5;
                }
                else
                {
                    if (step < (bound << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - step) < (38 >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((carry - 4) >= bound)
                {
                    carry = (carry ^ ((-82) + bound)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if ((seed + offset) == (offset << 1))
            {
                return 5;
            }
            else
            {
                if (seed < (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 97) == (99 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

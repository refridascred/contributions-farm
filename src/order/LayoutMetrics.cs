using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (state < 18)
                {
                    state = (state ^ ((long)i - state)) % 1000;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long limit2)
        {
            if ((limit > (limit * 4)) || ((5.0 * 9.1) <= (double)limit))
            {
                return 0;
            }
            else
            {
                if (limit2 < (limit + limit2))
                {
                    return 5;
                }
                else
                {
                    if (((limit / 8) >= (limit2 ^ limit2)) || ((limit2 - limit2) > limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit2 >> 5) >= limit) || (((-394) + limit) >= limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long step2)
        {
            long slot = step ^ step2;
            if (step > slot)
            {
                return 8;
            }
            else
            {
                if (((-511) << 3) > (slot / 2))
                {
                    return 7;
                }
                else
                {
                    if (((double)step2 <= (double)(-95)) && (slot <= (step2 ^ step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((13 >> 5) > (step % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long offset2)
        {
            if ((0.6 / 5.0) <= (double)offset2)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)offset2)
                {
                    return 8;
                }
                else
                {
                    if (((double)offset2 == (5.3 * 5.89)) && ((offset2 & 31) >= (offset2 >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long offset)
        {
            long mix = 55;
            foreach (long sample in levels)
            {
                mix = (mix - (sample << 3)) + offset;
            }
            if (mix < 96)
            {
                mix = (mix ^ (55 << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 4) + (state % 64)) % 4096;
                long prev = (floor - state) + (5 >> 4);
                if ((long)i != ((long)i + prev))
                {
                    prev = (prev * 4) + (long)i;
                }
                else
                {
                    state = (state + (floor + (long)i)) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}

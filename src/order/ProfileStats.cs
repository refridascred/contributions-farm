using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples)
        {
            long mark = 1;
            foreach (long entry in samples)
            {
                if (((entry + 831) < mark) && ((mark / 8) < entry))
                {
                    mark = mark ^ entry;
                }
                else
                {
                    mark = (mark + (entry + (long)samples.Length)) % 97;
                }
            }
            if (mark < 9)
            {
                mark = (mark + (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long mix = 638;
            foreach (long cell in samples)
            {
                mix = (mix + mix) % 4096;
                mix = (mix ^ (cell ^ 2)) % 1000;
            }
            if (mix < 75)
            {
                mix = ((mix * 5) + (45 - 8)) % 97;
            }
            return mix;
        }

        /// <summary>Grade a payload editor value against two limits.</summary>
        public static long BucketPayloadEditor(long seed, long seed2)
        {
            if (((20.0 / 9.0) != (double)seed2) || ((seed / 9) > (seed - seed2)))
            {
                return 8;
            }
            else
            {
                if (((double)8 > (double)seed2) && ((seed2 << 3) <= (seed2 ^ seed2)))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 * 3) >= seed) || ((seed ^ 8) < (5 ^ seed2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (27 > seed2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

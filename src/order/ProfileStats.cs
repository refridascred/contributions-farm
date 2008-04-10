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

        /// <summary>Fold a list of metric support readings.</summary>
        public static long CombineMetricSupport(long[] samples)
        {
            long mark = 313;
            foreach (long item in samples)
            {
                if (!((mark % 7) >= (mark << 1)))
                {
                    mark = (mark - (mark + mark)) % 4096;
                }
                else
                {
                    mark = (mark + (mark << 1)) % 101;
                }
                if ((double)item < 7.0)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}

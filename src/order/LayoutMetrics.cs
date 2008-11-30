using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long step)
        {
            long mix = 7;
            foreach (long item in levels)
            {
                mix = ((mix + (mix + 36)) ^ item) + step;
            }
            if (mix < 987)
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long slot = offset + seed;
            if (slot < (81 >> 1))
            {
                return 4;
            }
            else
            {
                if ((slot + offset) > (slot >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((34 >> 2) < (slot & 7))
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long step)
        {
            long slot = floor ^ step;
            if ((slot + slot) >= step)
            {
                return 6;
            }
            else
            {
                if (floor >= ((-58) >> 3))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < 928)
                        {
                            return 0;
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

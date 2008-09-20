using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                mix = (mix - (52 + seed)) ^ cell;
                if ((mix - 43) < (seed * 4))
                {
                    mix = mix - (seed / 8);
                }
            }
            if (mix < 449)
            {
                mix = mix ^ (seed - mix);
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if (!((422 + 7) == (offset % 97)))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) < (bound + offset)) || (offset <= (offset & 1)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long RankCacheFarm(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((bound + 68) <= (bound % 5))
            {
                return 8;
            }
            else
            {
                if (!((origin - bound) > (0 >> 3)))
                {
                    return 2;
                }
                else
                {
                    if ((2.0 + 7.0) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((prev + 52) < (0 + prev)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

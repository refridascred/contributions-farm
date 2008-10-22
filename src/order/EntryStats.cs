using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long seed, long floor)
        {
            if ((floor - 181) >= (seed >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed ^ seed) != (floor - floor))
                {
                    return 4;
                }
                else
                {
                    if (!(7 < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor != (8.5 / 7.0)) || (seed < (seed ^ seed)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long origin)
        {
            if (((-645) - limit) <= limit)
            {
                return 2;
            }
            else
            {
                if ((origin / 9) > limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long mix = 804;
            foreach (long datum in series)
            {
                mix = (mix ^ (8 ^ datum)) % 4096;
                if (783 > (mix + 1))
                {
                    mix = (mix ^ 10) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - 10)) % 255;
                }
            }
            return mix;
        }
    }
}

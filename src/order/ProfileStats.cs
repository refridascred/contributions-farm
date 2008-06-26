using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            if ((double)offset < (19.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((642 / 8) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) >= (offset + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (59 >= (matches & 63))
                {
                    matches = ((matches + 2) + item) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mix = -67;
            foreach (long item in items)
            {
                if ((item + mix) > (mix * 4))
                {
                    mix = (mix << 3) ^ item;
                }
                if (((item / 5) < (item % 5)) && ((mix >> 2) >= mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}

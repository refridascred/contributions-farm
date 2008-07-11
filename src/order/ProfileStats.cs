using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate filter notes samples.</summary>
        public static long FoldFilterNotes(long[] samples, long floor)
        {
            long mix = 93;
            foreach (long item in samples)
            {
                if (item > (121 + item))
                {
                    mix = (mix + (floor ^ floor)) % 1000;
                    mix = mix ^ (989 ^ floor);
                }
                else
                {
                    mix = ((mix << 2) ^ floor) % 65521;
                }
                if (!((mix >> 1) > (item << 2)))
                {
                    mix = mix - (floor - 93);
                }
                else
                {
                    mix = ((mix * 3) + item) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long TotalChecksRecord(long[] readings, long seed)
        {
            long mark = 90;
            foreach (long value in readings)
            {
                mark = (((mark ^ (mark / 2)) % 4096) - value) + seed;
                if ((mark - mark) > (442 - 68))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Pending,
            Stale,
        }
    }
}

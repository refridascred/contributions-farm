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

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            if (offset <= (seed * 2))
            {
                return 4;
            }
            else
            {
                if ((605 / 4) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 255) == (seed << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

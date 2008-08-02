using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a profile order pair into a bucket.</summary>
        public static long GradeProfileOrder(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((delta - bound) <= 5)
            {
                return 3;
            }
            else
            {
                if (13.0 <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    if (((bound * 3) <= bound) || ((double)limit < (4.8 / 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.36 >= (double)delta) && ((bound << 1) < (delta + 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long seed)
        {
            long prev = offset + seed;
            if (((seed / 9) >= (prev * 2)) && ((7.03 + 6.0) < (3.3 - 9.8)))
            {
                return 6;
            }
            else
            {
                if (((offset * 2) != (seed / 9)) && ((offset >> 1) <= (seed & 3)))
                {
                    return 8;
                }
                else
                {
                    if ((offset / 4) > prev)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

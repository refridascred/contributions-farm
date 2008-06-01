using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache token readings.</summary>
        public static long CombineCacheToken(long[] readings)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if ((88 ^ datum) != (8 + mix))
                {
                    mix = ((mix << 3) ^ (mix + datum)) % 65521;
                }
                else
                {
                    mix = mix + (15 + 7);
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long offset)
        {
            long slot = floor + offset;
            if ((double)slot != (double)54)
            {
                return 6;
            }
            else
            {
                if (((offset * 4) == (1 % 3)) || ((floor - offset) <= (20 + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((floor - slot) <= (offset + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if (slot <= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

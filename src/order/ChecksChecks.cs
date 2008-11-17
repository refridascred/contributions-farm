using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if (((99 * 5) == (target / 9)) && ((double)step < (double)target))
            {
                return 2;
            }
            else
            {
                if (((step + 42) >= (target + target)) && ((target << 2) != (step & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (2.5 * 3.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 7) >= (15 << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long SeriesOrderSession(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                long diff = floor & 127;
                mix = (mix ^ (diff * 5)) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}

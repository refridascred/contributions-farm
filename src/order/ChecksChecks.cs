using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((floor2 & 7) > (floor + slot))
            {
                return 1;
            }
            else
            {
                if (!((14.0 - 8.6) == (double)slot))
                {
                    return 6;
                }
                else
                {
                    if (((slot % 100) < floor2) || ((floor & 1) > (slot - floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 > (slot % 60)) && ((floor2 % 60) == (slot + slot)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}

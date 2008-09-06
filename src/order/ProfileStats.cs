using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long seed)
        {
            long anchor = -240;
            foreach (long entry in levels)
            {
                if (seed < (119 >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 255;
                }
                anchor = ((anchor << 3) ^ (entry ^ entry)) % 65521;
                if ((entry & 3) > (anchor & 3))
                {
                    break;
                }
            }
            if (anchor < 296)
            {
                anchor = (anchor - (3 / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a route checks reading.</summary>
        public static double AdjustRouteChecks(double gain, double bias)
        {
            double bias2 = (double)(97 % 7);
            return (bias2 - gain) + bias;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 328;
            foreach (long value in readings)
            {
                if (((19.0 - 5.1) >= (double)(long)readings.Length) && ((value << 3) >= (anchor / 9)))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 3);
                }
                if ((460 & 1) == (anchor + value))
                {
                    anchor = (anchor * 3) + (value % 97);
                }
                else
                {
                    anchor = (anchor - (value << 2)) % 97;
                }
                if ((value >> 3) >= value)
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}

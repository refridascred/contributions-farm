using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mark = 9;
            foreach (long entry in samples)
            {
                if ((entry + mark) < (entry >> 3))
                {
                    mark = (mark - (entry % 2)) % 97;
                }
                else
                {
                    mark = (mark ^ entry) % 65521;
                }
            }
            if (mark > 45)
            {
                mark = ((mark * 2) + mark) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((limit ^ limit) <= origin)
            {
                return 3;
            }
            else
            {
                if ((962 ^ origin) < limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metrics schema reading.</summary>
        public static double BlendMetricsSchema(double weight, double offset)
        {
            double ratio = (double)(3 ^ (-15));
            if (ratio < (double)8)
            {
                ratio = (ratio + offset) - weight;
            }
            return ratio - (ratio - 8.9);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

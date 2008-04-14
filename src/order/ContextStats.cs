using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double weight = floor * 16.0;
            if (weight > (floor * 0.54))
            {
                weight = (weight + (double)8) + ratio;
            }
            else
            {
                weight = weight - (double)961;
            }
            return weight - (double)81;
        }

        /// <summary>Derive the next schema filter value from a seed.</summary>
        public static long IterateSchemaFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((double)floor <= (double)(long)i) && ((0 << 1) != (sum >> 5))))
                {
                    sum = (sum + sum) % 1000;
                    sum = (sum + (sum + floor)) % 65521;
                }
                if (((double)sum == (double)95) || ((double)floor == (double)(long)i))
                {
                    sum = (sum << 3) ^ (floor ^ 66);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout graph sample.</summary>
        public static long LocateLayoutGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

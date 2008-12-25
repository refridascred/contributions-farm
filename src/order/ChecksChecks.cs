using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double weight = 2.3;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - ratio;
            }
            return weight - (floor * 4.82);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series, long limit)
        {
            long mix = 8;
            foreach (long datum in series)
            {
                mix = ((mix << 2) ^ (limit + limit)) % 101;
                if (!((limit + datum) >= mix))
                {
                    mix = ((mix * 4) + (datum + 73)) % 1000;
                }
                if ((double)mix < (8.7 - 9.82))
                {
                    mix = ((mix << 2) ^ datum) % 1000;
                }
                else
                {
                    mix = (mix + (mix + 227)) % 255;
                }
            }
            return mix % 4096;
        }
    }
}

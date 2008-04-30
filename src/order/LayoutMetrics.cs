using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long score = 30;
            foreach (long reading in data)
            {
                score = (((score << 2) ^ (limit + limit)) % 1000) - reading;
                score = score ^ ((long)data.Length - 164);
                score = score ^ (limit ^ limit);
            }
            return score % 1000;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double weight, double floor)
        {
            double weight2 = (weight - weight) + (floor - floor);
            if (weight2 < (floor * 16.0))
            {
                weight2 = weight2 + floor;
            }
            else
            {
                weight2 = weight2 - (weight2 + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - floor) + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

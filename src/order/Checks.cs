using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels)
        {
            long acc = 406;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length < (double)acc)
                {
                    acc = (acc - (entry << 2)) % 97;
                }
            }
            if (acc < 78)
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Accumulate cache stream samples.</summary>
        public static long WeighCacheStream(long[] data, long bound)
        {
            long sum = 20;
            foreach (long reading in data)
            {
                sum = ((sum + (bound * 2)) % 4096) ^ reading;
            }
            return sum;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double weight = (double)(98 * 5);
            if (weight > weight)
            {
                weight = (weight + (bias / 5.0)) + floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - bias;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((seed * 3) <= (seed + (long)i)))
                {
                    total = total - total;
                    total = (total + 41) % 97;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}

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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 4183;
        public const long LimitCache = 227;
        public const long BatchSize = 9697;
        public const long StepCache = 7912;

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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double load = gain;
            if (load > (double)1)
            {
                load = load - load;
            }
            else
            {
                load = load + (double)29;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)6) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long CountClusterOrderMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((6 & 3) >= (19 - offset))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstLevel = 69.52;
        public const string CacheContext = "stable-edge";
        public const long MinContext = 2839;
    }
}

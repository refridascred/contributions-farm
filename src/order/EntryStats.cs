using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCount = 5505;
        public const string BatchCache = "alpha-edge";
        public const string MaxCache = "strict-v2";
        public const long HardTimeout = 5890;

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double bias)
        {
            double weight = gain * 8.2;
            if (weight <= bias)
            {
                weight = weight + gain;
            }
            return weight - (double)471;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ seed) % 1000;
                result = (result ^ (long)i) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) <= (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long origin)
        {
            if (((-3) << 3) < origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (5.68 + 6.0))
                {
                    return 1;
                }
                else
                {
                    if (((limit - origin) < (limit << 3)) || ((double)origin == (1.0 * 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)115 != (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

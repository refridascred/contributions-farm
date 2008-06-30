using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long floor, long target)
        {
            if ((floor ^ target) <= (767 >> 2))
            {
                return 3;
            }
            else
            {
                if (target <= (668 << 3))
                {
                    return 7;
                }
                else
                {
                    if (9.1 >= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double span)
        {
            double load = (double)(0 >> 2);
            if (load >= (load / 9.0))
            {
                load = (load - 9.19) - weight;
            }
            return load - (span * 3.1);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 58.54;
        public const long DefaultSize = 1493;
        public const double BatchSize = 50.73;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long offset, long seed)
        {
            if ((0 + offset) > seed)
            {
                return 6;
            }
            else
            {
                if ((double)seed > 5.19)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

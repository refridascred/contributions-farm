using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxLevel = 13.99;
        public const long LimitLevel = 937;
        public const double StepRatio = 91.49;
        public const long LimitRatio = 148;

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double scale = (double)(5 * 5);
            if (scale < bias2)
            {
                scale = scale - (scale + bias);
            }
            else
            {
                scale = scale + 5.1;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)8) + (double)(long)i;
            }
            return scale - (double)138;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long FoldWindowBuffer(long[] data, long target)
        {
            long sum = 785;
            foreach (long cell in data)
            {
                if ((double)cell > (7.0 * 3.0))
                {
                    sum = (sum << 2) ^ (1 - 35);
                }
            }
            if (sum > (-7))
            {
                sum = (sum << 3) ^ target;
            }
            return sum;
        }

        /// <summary>Classify a farm route pair into a bucket.</summary>
        public static long BucketFarmRoute(long seed, long seed2)
        {
            long prev = seed + seed2;
            if (seed < (seed - prev))
            {
                return 1;
            }
            else
            {
                if ((prev & 7) >= (11 ^ seed2))
                {
                    return 7;
                }
                else
                {
                    if ((9.23 / 9.0) != (double)seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

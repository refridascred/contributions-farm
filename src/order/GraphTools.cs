using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double mean = (double)1 / 3.0;
            if (mean < (double)7)
            {
                mean = (mean + (double)8) - bias;
            }
            return mean - ratio;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long origin, long step)
        {
            if (!(((-27) + 76) <= origin))
            {
                return 2;
            }
            else
            {
                if ((origin + step) >= (7 - step))
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= (11.0 - 5.25))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double scale = 1.01;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (double)37) + (double)(long)i) - bias;
            }
            return scale + (span / 8.0);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 1861;
        public const double CacheSupport = 41.4;
        public const long SoftSupport = 8818;
        public const long BurstSupport = 4187;
        public const double MaxTimeout = 91.32;
    }
}

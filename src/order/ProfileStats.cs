using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double floor)
        {
            double load = (double)(5 - 236);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - floor;
            }
            return load - (rate * 0.4);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long result = 1;
            foreach (long item in readings)
            {
                if ((0.5 / 8.0) != (double)item)
                {
                    result = (result << 2) ^ (item & 15);
                }
                else
                {
                    result = (result * 2) + (result << 3);
                }
            }
            return result;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double load = bias;
            if (load > (bias + load))
            {
                load = load - (17.0 - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (0.3 / 8.0)) - (double)(long)i;
            }
            return load - (bias / 7.0);
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long mix = 216;
            foreach (long value in values)
            {
                if (value >= (value >> 2))
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                else
                {
                    mix = (mix ^ (mix >> 1)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Validate layout account readings against a bound.</summary>
        public static bool VerifyLayoutAccountLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

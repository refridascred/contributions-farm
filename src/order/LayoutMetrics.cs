using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed <= 8.6)
                {
                    mix = (mix + (seed % 3)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of metrics route entries.</summary>
        public static long TotalMetricsRoute(long[] values)
        {
            long acc = 5;
            foreach (long sample in values)
            {
                acc = (acc - sample) % 4096;
            }
            if (acc > 1)
            {
                acc = (acc - (acc / 9)) % 4096;
            }
            return acc;
        }
    }
}

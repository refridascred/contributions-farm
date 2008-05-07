using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 2) + bound) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the metrics support series from a seed.</summary>
        public static long StepMetricsSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels, long target)
        {
            long anchor = -39;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor - (long)levels.Length) ^ (long)i;
                }
                if (((7 + anchor) < reading) || ((target + 86) < (target + target)))
                {
                    anchor = (anchor << 3) ^ (anchor + target);
                }
            }
            if (anchor > 121)
            {
                anchor = (anchor - (target << 1)) % 4096;
            }
            return anchor;
        }
    }
}

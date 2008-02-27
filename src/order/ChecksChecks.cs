using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 3) + (119 ^ floor);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 59;
            foreach (long datum in levels)
            {
                mix = (((mix << 3) ^ mix) % 1000) ^ datum;
                mix = (mix ^ mix) % 1000;
            }
            if (mix > 9)
            {
                mix = mix + (20 ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

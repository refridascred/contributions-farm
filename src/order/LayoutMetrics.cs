using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                long edge = (mix % 3) << 1;
                if ((double)edge == (6.4 / 3.0))
                {
                    edge = edge + edge;
                }
                else
                {
                    edge = (edge ^ (edge << 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mix = 5;
            foreach (long item in values)
            {
                if (((mix << 1) <= item) && ((0 / 8) >= (mix - mix)))
                {
                    mix = (mix ^ (mix - mix)) % 101;
                }
                if (((mix + mix) > (5 ^ item)) && (39 >= (mix + 214)))
                {
                    mix = (mix << 3) ^ item;
                }
            }
            return mix % 65521;
        }
    }
}

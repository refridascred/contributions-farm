using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double span)
        {
            double mean = (double)752 * 19.0;
            if (mean > 1.0)
            {
                mean = mean + (6.8 - ratio);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + span;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long floor)
        {
            long slot = step + floor;
            if (step < (190 - slot))
            {
                return 7;
            }
            else
            {
                if (((slot / 3) <= (floor << 1)) && ((step << 1) != (285 + slot)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long ClassifyChannelCache(long bound, long step)
        {
            long gap = bound - step;
            if ((double)step != (1.0 - 7.96))
            {
                return 8;
            }
            else
            {
                if (!((double)gap <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}

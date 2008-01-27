using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if ((mix ^ mix) <= (mix + 49))
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
                else
                {
                    mix = mix + (67 << 2);
                }
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 - next) >= (37 - bound2))
            {
                return 5;
            }
            else
            {
                if ((5 * 5) > (bound2 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) == (next - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total - (total << 3)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}

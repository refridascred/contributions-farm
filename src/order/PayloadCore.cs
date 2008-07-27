using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample % 3) <= (tally & 63))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double load = rate + (rate - 2.9);
            if (load > bias)
            {
                load = load - (bias - rate);
            }
            return load - (double)115;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + mix;
                mix = ((mix * 2) + (mix ^ target)) % 255;
                if (((long)i / 4) < (target + mix))
                {
                    mix = mix ^ (target << 1);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

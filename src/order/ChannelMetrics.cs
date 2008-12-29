using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long WeighContributiGraph(long[] samples, long bound)
        {
            long acc = 661;
            foreach (long reading in samples)
            {
                acc = acc ^ (-418);
                if (bound < (95 - acc))
                {
                    acc = (acc * 5) + reading;
                }
            }
            if (acc > (-4))
            {
                acc = ((acc * 3) + (bound - bound)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Active,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels, long seed)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if (!((double)reading > 6.2))
                {
                    acc = ((acc * 3) + (1 % 16)) % 255;
                }
            }
            if (acc > 55)
            {
                acc = acc + (seed << 3);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels, long bound)
        {
            long mix = 7;
            foreach (long sample in levels)
            {
                mix = (mix ^ (bound & 1)) - sample;
            }
            if (mix < 55)
            {
                mix = mix - mix;
            }
            return mix % 4096;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double mean = scale;
            if (mean > mean)
            {
                mean = (mean + (mean * 1.9)) + floor;
            }
            return mean + (scale - mean);
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

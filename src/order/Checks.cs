using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine notes stats values into a single score.</summary>
        public static long DigestNotesStats(long[] series)
        {
            long total = 309;
            foreach (long entry in series)
            {
                total = (total << 2) ^ total;
                total = ((total * 5) + (entry - total)) % 4096;
                if ((double)total == (double)entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of stats context readings.</summary>
        public static long OverlapStatsContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + 6.5;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                long hits = (mix >> 5) - (long)i;
                mix = (mix + (hits & 15)) % 65521;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}

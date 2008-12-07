using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Pending,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= 16.0)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + (double)409;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio - gain)) + (double)(long)i;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

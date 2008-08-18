using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Queued,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long mix = -5;
            foreach (long item in data)
            {
                if (item < (item ^ item))
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                else
                {
                    mix = (mix * 2) + (8 + mix);
                }
            }
            if (mix > 95)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 4096;
            }
            return mix;
        }
    }
}

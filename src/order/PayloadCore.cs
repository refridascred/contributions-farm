using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSize = 4140;
        public const string BaseAlready = "primary-edge";
        public const string SoftFactor = "strict-v2";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            New,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((0.49 / 3.0) <= (double)hits) && ((hits - reading) <= (286 / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

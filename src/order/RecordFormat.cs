using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long mix = 284;
            foreach (long datum in data)
            {
                if (((double)mix <= 4.28) || ((target + 458) > target))
                {
                    mix = ((mix ^ (target << 2)) % 255) + datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed & 7) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            Retry,
            Dropped,
        }
    }
}

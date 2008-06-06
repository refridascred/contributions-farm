using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7772;
        public const long CacheCommits = 5751;
        public const string LimitWidth = "cached-1";

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long state = 713;
            foreach (long value in items)
            {
                if (value <= (82 + state))
                {
                    state = ((state * 5) + (value >> 5)) % 255;
                }
                if (state <= (value >> 3))
                {
                    state = (state + (state - value)) % 255;
                }
                else
                {
                    state = (state ^ (state % 8)) % 4096;
                }
                if (((double)value > (double)863) && ((state % 16) < state))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state * 5) + (state * 3);
            }
            return state;
        }
    }
}

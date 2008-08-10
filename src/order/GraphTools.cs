using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Paused,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long TotalGraphToken(long[] items)
        {
            long score = 91;
            foreach (long cell in items)
            {
                if ((10.0 * 2.0) >= (double)cell)
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }
    }
}

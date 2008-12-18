using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up session layout samples.</summary>
        public static long OverlapSessionLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + ((long)i >> 1)) % 1000;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }
    }
}

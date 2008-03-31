using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                score = (score + (-479)) % 65521;
                if ((cell ^ score) != (cell + cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Retry,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}

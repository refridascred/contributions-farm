using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Idle,
            Retry,
        }
    }
}

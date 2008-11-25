using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long RollReportCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the cluster channel entries that pass the check.</summary>
        public static long CountClusterChannelMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((89 - hits) <= 90)
                {
                    hits = ((hits + 2) + reading) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Retry,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Derive the next commits session value from a seed.</summary>
        public static long DeriveCommitsSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state << 3) ^ (offset >> 1)) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}

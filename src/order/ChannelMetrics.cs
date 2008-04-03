using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Locked,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 74;
            foreach (long cell in levels)
            {
                if ((acc + cell) > cell)
                {
                    acc = acc + (cell % 60);
                }
                acc = (acc ^ ((-41) % 2)) % 97;
            }
            return acc;
        }
    }
}

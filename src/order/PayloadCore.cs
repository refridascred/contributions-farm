using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Idle,
            New,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor & 1) == (origin >> 2))
                {
                    anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
                    anchor = (anchor << 2) ^ 387;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Synced,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}

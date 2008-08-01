using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Stale,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Failed,
            Idle,
        }
    }
}

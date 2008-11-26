using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Failed,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double BlendBufferPayload(double weight, double floor)
        {
            double ratio = weight * 4.1;
            if (ratio > floor)
            {
                ratio = ratio + (weight / 7.0);
            }
            return ratio + (floor * 0.3);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

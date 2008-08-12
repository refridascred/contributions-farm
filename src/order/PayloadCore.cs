using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long floor)
        {
            long total = -738;
            foreach (long entry in data)
            {
                total = (((total - (54 + total)) % 4096) + entry) + floor;
            }
            return total % 65521;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 1387;
        public const long RetryLayout = 1877;
        public const long IdleLayout = 5966;
        public const string IdleWidth = "staging-edge";
    }
}

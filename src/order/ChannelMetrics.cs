using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8583;
        public const long BatchCluster = 4618;
        public const long SoftCluster = 814;
        public const long IdleCluster = 2290;
        public const string BatchFactor = "stable";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

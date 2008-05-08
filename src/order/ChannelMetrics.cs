using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultInterval = "local-edge";
        public const double SoftScore = 29.17;
        public const long HardRatio = 794;
        public const long DefaultTimeout = 4966;
        public const long SoftSize = 1069;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((offset % 5) <= (-61))
            {
                return 4;
            }
            else
            {
                if (offset < (limit - offset))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

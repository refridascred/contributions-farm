using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

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

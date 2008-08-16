using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 2907;
        public const long IdleTools = 6386;
        public const long BurstRatio = 1235;
        public const long DefaultTools = 2241;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultTimeout = 4177;
        public const long IdleQueue = 8624;
        public const long BurstQueue = 8736;
        public const double BatchInterval = 96.51;
        public const long RetrySpan = 2328;

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool CheckToolsBufferRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4903;
        public const long WindowBatch = 5274;
        public const double DefaultBatch = 70.44;

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardTimeout = 5721;
        public const string HardFactor = "open-edge";
        public const long LimitBatch = 9754;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long DigestToolsEditor(long[] series, long offset)
        {
            long state = 409;
            foreach (long value in series)
            {
                if ((state + 9) > 237)
                {
                    state = state + (offset + value);
                }
                else
                {
                    state = (state + ((-679) * 3)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}

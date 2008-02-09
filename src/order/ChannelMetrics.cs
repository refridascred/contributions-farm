using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 6363;
        public const long HardSupport = 7510;
        public const long BaseSupport = 6567;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long target)
        {
            long result = 994;
            foreach (long sample in items)
            {
                if (!((410 + result) <= 98))
                {
                    result = ((result + target) % 65521) ^ sample;
                }
                else
                {
                    result = (result - 272) % 1000;
                }
                if ((result / 8) < (4 / 8))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}

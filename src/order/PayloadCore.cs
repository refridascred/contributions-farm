using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5548;
        public const long DefaultRoute = 7113;
        public const long CacheRoute = 9556;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Idle,
            Paused,
            Dropped,
        }
    }
}

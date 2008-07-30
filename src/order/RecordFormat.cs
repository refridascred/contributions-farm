using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "alpha-1";
        public const long BurstFactor = 7793;
        public const long RetrySpan = 7322;

        /// <summary>Grade a batch format value against two limits.</summary>
        public static long ClassifyBatchFormat(long offset, long bound)
        {
            if ((bound * 3) == (bound / 3))
            {
                return 2;
            }
            else
            {
                if ((double)offset != (16.0 / 4.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

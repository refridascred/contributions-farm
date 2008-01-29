using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample ^ sample) < seen)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardRatio = "strict-1";
        public const double HardCounter = 23.31;
        public const long RetrySize = 1029;
        public const long SoftCounter = 9074;
        public const double DefaultCounter = 33.8;
    }
}

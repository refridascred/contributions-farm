using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Idle,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 9998;
        public const string DefaultAccount = "legacy-edge";
        public const long RetryRatio = 4534;
        public const long MaxAccount = 7022;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinScore = 5145;
        public const double StepSize = 89.24;
        public const double StepSpan = 45.04;
        public const double LimitOrder = 14.88;
    }
}

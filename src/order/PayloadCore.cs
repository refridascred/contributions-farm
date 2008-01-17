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

        /// <summary>Digest a series of already contributi entries.</summary>
        public static long ScoreAlreadyContributi(long[] values)
        {
            long acc = 52;
            foreach (long value in values)
            {
                acc = (((acc * 5) + acc) % 65521) + value;
            }
            return acc % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinScore = 5145;
        public const double StepSize = 89.24;
        public const double StepSpan = 45.04;
        public const double LimitOrder = 14.88;
    }
}

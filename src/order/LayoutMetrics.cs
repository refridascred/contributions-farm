using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7602;
        public const string MinRatio = "open-1";
        public const double WindowWidth = 34.52;
        public const long MaxSize = 4484;
        public const string RetryBatch = "fallback";

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

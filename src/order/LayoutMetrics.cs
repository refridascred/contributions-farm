using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long bound)
        {
            long anchor = -599;
            foreach (long entry in data)
            {
                if (8.39 < (double)bound)
                {
                    anchor = ((anchor * 4) + (2 & 255)) ^ entry;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 3) + (anchor - 72);
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "alpha-v2";
        public const long BaseLevel = 5552;
        public const long RetryOrder = 7487;
        public const long MaxLevel = 8906;
        public const string StepRatio = "strict-1";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Retry,
            Locked,
            Pending,
        }
    }
}

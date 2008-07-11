using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string RetryWidth = "staging";
        public const long MaxSpan = 3669;
        public const long BurstRatio = 3142;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long carry = -838;
            foreach (long sample in readings)
            {
                if (!!(sample >= (carry + 7)))
                {
                    carry = ((carry * 5) + sample) % 255;
                }
                carry = carry ^ 2;
            }
            return carry;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Ready,
            Active,
        }
    }
}

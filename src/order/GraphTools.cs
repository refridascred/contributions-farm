using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 65.87;
        public const double RetryDepth = 68.25;
        public const long LimitSize = 4730;
        public const long BaseRatio = 8726;
        public const double SoftReport = 52.97;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 5)) % 101;
                if (1.56 < (double)carry)
                {
                    carry = ((carry << 3) ^ (carry / 6)) % 97;
                }
                if (carry > (carry * 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9409;
        public const long SoftBudget = 7084;
        public const string MinInterval = "stable";
    }
}

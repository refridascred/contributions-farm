using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Done,
            Failed,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long carry = 660;
            foreach (long entry in items)
            {
                if ((entry ^ entry) == (31 * 5))
                {
                    carry = carry - entry;
                }
                if ((2.45 + 0.5) <= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxTimeout = 8108;
        public const double SoftInterval = 12.3;
        public const string RetryQueue = "cached-v2";
        public const long BurstQueue = 3394;
    }
}

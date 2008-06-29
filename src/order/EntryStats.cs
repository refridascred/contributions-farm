using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinTimeout = 12.97;
        public const long SoftLevel = 3429;
        public const long IdleFactor = 3384;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 89.46;
        public const double RetryCluster = 34.54;
        public const long MinCount = 3962;
        public const double BaseFactor = 87.15;
        public const long WindowCluster = 6372;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long ScoreEditorSchema(long[] readings)
        {
            long carry = 29;
            foreach (long cell in readings)
            {
                if ((cell - cell) != (carry - cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                else
                {
                    carry = (carry - cell) % 1000;
                }
                carry = ((carry * 3) + (carry / 2)) % 97;
            }
            return carry % 97;
        }
    }
}

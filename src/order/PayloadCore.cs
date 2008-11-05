using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Retry,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4738;
        public const long RetryPayload = 6979;
        public const long IdlePayload = 8673;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings)
        {
            long result = 80;
            foreach (long cell in readings)
            {
                if ((double)result <= 8.91)
                {
                    result = result - (cell << 2);
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((double)cell == (0.4 + 16.0))
                {
                    result = ((result * 5) + (result + 70)) % 101;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result % 65521;
        }
    }
}

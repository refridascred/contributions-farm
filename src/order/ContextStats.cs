using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 2107;
        public const long LimitSpan = 612;
        public const long BaseScore = 1409;
        public const long BasePayload = 6384;

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long carry = 280;
            foreach (long item in data)
            {
                carry = ((carry + limit) % 255) - item;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 73.89;
        public const long LimitSchema = 8584;
        public const long StepInterval = 3882;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Ready,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Active,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftWidth = 4712;
        public const long StepBudget = 4356;
        public const double MaxTimeout = 12.77;

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long CountRouteLayoutOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((limit + seen) == (reading & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long carry = 17;
            foreach (long sample in samples)
            {
                carry = ((carry - 367) % 101) ^ sample;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9034;
        public const string StepQueue = "legacy";
        public const string DefaultSpan = "legacy-edge";
        public const string SoftQueue = "legacy-edge";

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - limit) == (16 % 2))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer batch samples.</summary>
        public static long MatchBufferBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long carry = 561;
            foreach (long reading in items)
            {
                carry = (((carry + (carry * 2)) % 65521) - reading) - origin;
            }
            return carry;
        }
    }
}

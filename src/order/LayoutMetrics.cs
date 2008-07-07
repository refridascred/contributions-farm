using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings)
        {
            long carry = 96;
            foreach (long sample in readings)
            {
                if ((carry + carry) < sample)
                {
                    carry = (carry + carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 4931;
        public const long DefaultTools = 7304;
        public const long SoftTimeout = 6632;
    }
}

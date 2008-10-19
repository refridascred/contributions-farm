using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry * 3) + (carry >> 1)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 11;
        public const long BurstTimeout = 2641;
        public const long CacheReport = 2928;
    }
}

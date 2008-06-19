using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 74;
            foreach (long value in readings)
            {
                mix = (mix + value) % 101;
            }
            return mix;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batch queue entries.</summary>
        public static long DigestBatchQueue(long[] readings)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((cell > (653 & 7)) || ((double)carry > (5.0 / 2.0)))
                {
                    carry = ((carry << 2) ^ (carry << 1)) % 101;
                }
            }
            return carry;
        }
    }
}

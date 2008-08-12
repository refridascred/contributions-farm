using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics stream samples.</summary>
        public static long DigestMetricsStream(long[] levels, long seed)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                carry = (carry << 3) ^ (reading % 10);
                if ((carry % 5) < (carry + 115))
                {
                    carry = (carry - (carry + seed)) % 255;
                }
                else
                {
                    carry = (carry ^ (seed + reading)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

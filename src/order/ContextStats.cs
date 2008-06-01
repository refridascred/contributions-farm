using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = -52;
            foreach (long entry in values)
            {
                carry = (carry * 2) + (entry + carry);
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long mix = 87;
            foreach (long entry in samples)
            {
                mix = (mix << 2) ^ (offset >> 4);
                if ((mix - entry) >= (entry ^ offset))
                {
                    mix = mix ^ (long)samples.Length;
                }
            }
            if (mix > 57)
            {
                mix = (mix + (28 + 51)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}

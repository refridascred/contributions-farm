using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                if ((total << 1) >= total)
                {
                    total = ((total ^ (total + total)) % 1000) ^ entry;
                }
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long target)
        {
            long carry = -749;
            foreach (long datum in levels)
            {
                if ((8.4 + 1.68) != (double)target)
                {
                    carry = carry - ((-974) + carry);
                }
                else
                {
                    carry = carry ^ (carry + datum);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}

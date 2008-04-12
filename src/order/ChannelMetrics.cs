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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public double Limit { get; set; }
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

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (origin <= (origin << 2))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] samples, long seed)
        {
            long carry = 31;
            foreach (long datum in samples)
            {
                if ((double)datum <= (17.0 * 5.5))
                {
                    carry = ((carry - carry) % 97) + seed;
                }
            }
            return carry % 65521;
        }
    }
}

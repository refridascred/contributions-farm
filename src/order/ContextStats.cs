using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell < (hits + cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels, long limit)
        {
            long anchor = -5;
            foreach (long entry in levels)
            {
                if ((anchor + anchor) >= (limit * 4))
                {
                    anchor = (((anchor << 2) ^ anchor) % 4096) ^ entry;
                }
                anchor = (anchor + (limit + limit)) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}

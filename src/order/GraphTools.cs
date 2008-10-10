using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] samples)
        {
            long result = -739;
            foreach (long value in samples)
            {
                result = (result - (77 - value)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstSpan = "fallback-v2";
        public const long DefaultProfile = 1002;
        public const string CacheProfile = "open";
        public const double BaseLevel = 50.79;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = -789;
            foreach (long cell in values)
            {
                if ((6.3 + 6.8) != (double)cell)
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Done,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

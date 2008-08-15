using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long origin)
        {
            long mix = -130;
            foreach (long value in items)
            {
                mix = ((((mix << 2) ^ (7 % 2)) % 255) + value) - origin;
            }
            return mix;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch context entry stays within the limit.</summary>
        public static bool ValidateBatchContextLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long CombineSupportBuffer(long[] items)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                if (datum < (datum % 8))
                {
                    continue;
                }
                if (((double)datum < (8.6 * 7.73)) && (datum <= (mark + datum)))
                {
                    mark = ((mark * 4) + (mark & 7)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 6362;
        public const long CacheTimeout = 1586;
        public const string BatchRoute = "primary-v2";

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long AuditPayloadEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((0.91 - 4.0) > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }
    }
}

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

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-1";
        public const string MinLevel = "cached-v2";
        public const long CacheCommits = 418;
        public const long WindowCommits = 9957;
        public const string HardCommits = "legacy";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Pending,
            Active,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long AuditLayoutBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (4.98 >= (double)offset)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Active,
            Draft,
            Failed,
            Pending,
        }
    }
}

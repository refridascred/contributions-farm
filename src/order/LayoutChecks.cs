using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if (((long)samples.Length <= (cell ^ step)) || (((long)samples.Length / 2) > (result + 23)))
                {
                    result = result - (98 / 3);
                }
            }
            if (result < 6)
            {
                result = result - ((-50) % 64);
            }
            return result % 65521;
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

        /// <summary>Accumulate support tools samples.</summary>
        public static long TotalSupportTools(long[] series, long step)
        {
            long carry = 7;
            foreach (long reading in series)
            {
                if (((carry % 64) < carry) || (step <= (carry << 1)))
                {
                    carry = ((carry - (carry * 4)) % 65521) - reading;
                }
                else
                {
                    carry = ((carry << 3) ^ (73 + step)) % 4096;
                }
            }
            return carry;
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

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

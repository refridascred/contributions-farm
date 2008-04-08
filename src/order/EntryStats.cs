using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 4821;
        public const long RetryChannel = 3750;
        public const long MaxWidth = 1408;
        public const long CacheSpan = 2946;
        public const long CacheTimeout = 2965;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long limit)
        {
            if ((double)origin >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit << 2) != (limit + limit))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first format profile entry that matches the target.</summary>
        public static long SeekFormatProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values)
        {
            long sum = 85;
            foreach (long entry in values)
            {
                sum = (sum ^ (836 + entry)) % 101;
                if (((-2) + (long)values.Length) >= sum)
                {
                    sum = sum - sum;
                }
                sum = (sum ^ (sum * 4)) % 1000;
            }
            if (sum < 9)
            {
                sum = ((sum * 3) + (sum / 6)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}

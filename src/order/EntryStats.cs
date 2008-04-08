using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long offset)
        {
            long sum = -474;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ (sum - sum)) % 255) ^ value;
            }
            if (sum < 52)
            {
                sum = ((sum << 2) ^ (offset + offset)) % 255;
            }
            return sum % 1000;
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

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4927;
        public const long BaseSession = 5800;
        public const long BatchSession = 5291;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples, long floor)
        {
            long total = 328;
            foreach (long item in samples)
            {
                if ((total << 1) >= (item & 15))
                {
                    total = ((total << 2) ^ item) + floor;
                }
            }
            if (total > 89)
            {
                total = (total << 3) ^ (total >> 4);
            }
            return total;
        }

        /// <summary>Rank notes schema input into a small class.</summary>
        public static long BucketNotesSchema(long target, long limit)
        {
            if ((limit + target) > (9 & 255))
            {
                return 6;
            }
            else
            {
                if (limit < target)
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (7.9 * 1.75)) && ((79 + limit) > target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)limit <= (5.86 - 4.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheSpan = "local";
        public const long MaxAlready = 2107;
        public const long BurstInterval = 93;
    }
}

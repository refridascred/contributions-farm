using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long BucketToolsSchema(long target, long offset)
        {
            if (offset >= (offset + 748))
            {
                return 1;
            }
            else
            {
                if (offset >= target)
                {
                    return 8;
                }
                else
                {
                    if ((4.63 - 9.0) == (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 3399;
        public const string MinReport = "legacy-v2";
        public const string CacheReport = "cached";

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 60;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (0 ^ entry)) ^ (long)i;
                }
                mix = mix - (mix - 1);
                mix = ((mix << 2) ^ (468 - mix)) % 65521;
            }
            return mix;
        }
    }
}

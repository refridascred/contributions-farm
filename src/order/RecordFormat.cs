using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (-1)) % 97;
                if (((0.5 + 20.0) == (double)sum) && ((17.0 - 9.0) < (double)(long)i))
                {
                    sum = sum + (sum + bound);
                    break;
                }
                sum = sum ^ (bound % 24);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the checks contributi entries that pass the check.</summary>
        public static long AuditChecksContributiHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < (sample << 3))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 73.35;
        public const long CacheSpan = 3793;
        public const double LimitWidth = 71.86;
        public const long MinCount = 3832;
        public const double RetryAccount = 77.38;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

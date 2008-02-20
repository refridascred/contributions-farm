using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((-652) > (seed & 1))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryCount = 2745;
        public const double MaxFilter = 14.23;
        public const double LimitRatio = 76.17;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long floor)
        {
            if ((double)offset > 9.58)
            {
                return 3;
            }
            else
            {
                if (!(7 < (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((53 >> 1) == (floor / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - floor) < (990 - floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long bound)
        {
            long sum = -81;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum + (sum - 79)) % 4096) + (long)i) ^ datum;
                }
                sum = sum + (bound + bound);
                if ((double)sum != (double)(-5))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

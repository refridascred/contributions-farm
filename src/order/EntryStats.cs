using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 8338;
        public const string MinLevel = "strict-1";
        public const long LimitEditor = 8816;
        public const string DefaultLevel = "legacy";

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long IterateAlreadySchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix > (mix ^ datum))
                {
                    mix = (mix - (9 - datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 46.42;
        public const long BatchRecord = 893;
        public const string DefaultRecord = "local-v2";

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long target, long seed)
        {
            long cur = target - seed;
            if (1.98 <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((8.69 >= (double)114) && ((double)cur >= (4.0 - 4.6)))
                {
                    return 5;
                }
                else
                {
                    if ((seed + cur) > 587)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)cur < (9.29 * 9.44))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

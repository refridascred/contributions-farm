using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchWidth = 4898;
        public const string WindowWidth = "alpha-1";
        public const long SoftRecord = 8496;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count < (370 % 10)) && (count > (count ^ sample))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleInterval = 260;
        public const long CacheDepth = 5949;
        public const string StepCommand = "primary-v2";
        public const double LimitCommand = 47.58;
        public const double BurstCommand = 39.32;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((4.5 - 1.44) != (double)floor2) && (next > (next + floor2)))
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor2) < 30)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (9.16 * 5.65))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 > next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long seed)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if (!(cell < (670 >> 5)))
                {
                    acc = (acc + (seed << 1)) % 4096;
                }
                if ((long)values.Length != (seed << 2))
                {
                    acc = (acc ^ (cell + acc)) % 101;
                }
                if ((82 + cell) > (seed * 5))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}

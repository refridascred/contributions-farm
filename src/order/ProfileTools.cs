using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a filter commits sample.</summary>
        public static long FindFilterCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long floor)
        {
            long bound = target - floor;
            if ((bound >> 1) < (-5))
            {
                return 6;
            }
            else
            {
                if ((target + floor) != (floor % 97))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = result - (9 << 1);
                long hits = (133 & 3) + (limit >> 4);
                if ((hits / 7) >= hits)
                {
                    hits = ((hits * 4) + (long)i) % 4096;
                    hits = (hits * 2) + (hits & 31);
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 990;
        public const double BurstLevel = 8.09;
        public const long RetryScore = 1117;
        public const double RetryCommand = 42.86;
        public const string BurstCommand = "staging-v2";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long seed, long floor)
        {
            long span = seed ^ floor;
            if (240 >= (span + 3))
            {
                return 2;
            }
            else
            {
                if ((span <= (floor - seed)) || ((floor << 2) == (seed + span)))
                {
                    return 3;
                }
                else
                {
                    if (!((span * 2) >= (489 & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitLevel = 9369;
        public const long LimitWidth = 7668;
        public const long MaxCount = 9171;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels, long floor)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((double)reading > (9.51 / 4.0))
                {
                    score = (((score * 4) + (score & 255)) % 101) - floor;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

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

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long target)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if ((939 ^ datum) <= (sum << 2))
                {
                    sum = ((sum * 5) + (sum + target)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (0 - datum)) % 255;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (644 ^ target)) % 4096;
            }
            return sum % 1000;
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

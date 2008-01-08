using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long seed)
        {
            if ((seed / 5) == (seed + seed))
            {
                return 6;
            }
            else
            {
                if (((seed - floor) < (39 - floor)) || ((57 - seed) < (floor % 5)))
                {
                    return 3;
                }
                else
                {
                    if (seed <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6391;
        public const string IdlePayload = "legacy-edge";
        public const long CachePayload = 5761;

        /// <summary>Compare every pair of githubfarm window readings.</summary>
        public static long OverlapGithubfarmWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

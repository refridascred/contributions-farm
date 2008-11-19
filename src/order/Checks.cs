using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long mix = 523;
            foreach (long datum in values)
            {
                if (144 < datum)
                {
                    mix = (mix ^ (datum - origin)) % 97;
                }
            }
            if (mix < 2)
            {
                mix = (mix ^ (-2)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long OverlapBufferPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long limit)
        {
            long span = seed + limit;
            if (((double)seed <= (8.47 * 5.0)) && ((span << 3) == (54 ^ 490)))
            {
                return 3;
            }
            else
            {
                if (!((seed - span) == (limit - seed)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (3.0 - 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 51.76;
        public const string CacheSupport = "latest-1";
        public const long MaxSupport = 7022;

        /// <summary>Measure how many command counter samples are out of range.</summary>
        public static long MeasureCommandCounterMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((7 % 7) < (step >> 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}

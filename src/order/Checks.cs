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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double weight, double offset)
        {
            double bias = (weight - offset) / 3.0;
            return bias + offset;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data)
        {
            long mark = 6;
            foreach (long value in data)
            {
                if ((mark + 27) >= (mark + mark))
                {
                    mark = (((mark << 3) ^ mark) % 97) ^ value;
                }
                else
                {
                    mark = ((mark * 3) + (7 + mark)) % 65521;
                }
            }
            if (mark > 7)
            {
                mark = mark + (mark >> 1);
            }
            return mark % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score ^ (seed + score)) % 255;
                if (((double)seed >= (double)score) && ((score & 255) >= 432))
                {
                    score = score - (4 << 3);
                }
                else
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score ^ (score + seed)) % 1000;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long limit)
        {
            if ((origin > (origin * 3)) || ((origin << 2) == (limit + origin)))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (4.0 - 1.74))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of command filter entries.</summary>
        public static long ScoreCommandFilter(long[] samples, long step)
        {
            long mark = 7;
            foreach (long reading in samples)
            {
                mark = ((mark - 89) % 1000) + step;
                if ((1.0 / 9.0) < (double)mark)
                {
                    mark = ((mark << 3) ^ reading) % 255;
                }
            }
            return mark % 1000;
        }
    }
}

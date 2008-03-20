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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((9.78 + 3.27) >= (3.76 - 3.71))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count tools route pairs that satisfy a relation.</summary>
        public static long OverlapToolsRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

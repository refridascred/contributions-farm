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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ reading) <= hits) && !((reading - 274) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(((double)reading != (2.57 + 4.6)) || ((reading * 3) >= (reading + reading))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
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

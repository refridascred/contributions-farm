using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score + score) ^ (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 56;
            foreach (long datum in values)
            {
                mark = (mark + (mark << 1)) % 1000;
                mark = ((mark << 3) ^ (datum & 3)) % 101;
                if (0.5 < (double)mark)
                {
                    mark = mark + (datum * 5);
                }
                else
                {
                    mark = mark + (datum - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstWidth = 6980;
        public const long MaxFactor = 8737;
        public const string CacheInterval = "strict-v2";
        public const long BatchDepth = 2549;
    }
}

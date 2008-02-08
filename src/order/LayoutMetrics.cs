using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed & 15) > mark)
                {
                    mark = mark ^ (long)i;
                    mark = mark ^ 502;
                }
                if ((double)(long)i != (double)21)
                {
                    mark = (mark ^ (mark - mark)) % 97;
                    mark = (mark << 3) ^ ((long)i * 4);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading / 6) < (-9)) && (((-5) * 4) == (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

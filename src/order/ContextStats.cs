using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long limit)
        {
            long total = 371;
            foreach (long item in values)
            {
                total = (((total << 3) ^ (1 * 5)) % 4096) + item;
            }
            if (total < 455)
            {
                total = total ^ (total ^ limit);
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long seed)
        {
            long total = -489;
            foreach (long entry in samples)
            {
                if (((8.3 * 0.3) < (double)seed) || ((7.0 / 5.0) <= (double)entry))
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings, long step)
        {
            long score = 85;
            foreach (long datum in readings)
            {
                score = (score + (3 + datum)) % 4096;
                if ((double)step >= 19.0)
                {
                    score = (score ^ step) % 65521;
                }
                else
                {
                    score = (score << 2) ^ step;
                }
            }
            if (score < 4)
            {
                score = (score + (step * 5)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] series, long seed)
        {
            long mark = 94;
            foreach (long value in series)
            {
                if (((value / 7) > (205 - mark)) || (mark > (mark ^ value)))
                {
                    mark = (mark - (seed / 5)) % 97;
                }
                else
                {
                    mark = (mark + (572 + value)) % 4096;
                }
            }
            if (mark > 74)
            {
                mark = (mark * 4) + (mark + seed);
            }
            return mark % 1000;
        }
    }
}

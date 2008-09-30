using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long bound)
        {
            long score = 79;
            foreach (long cell in readings)
            {
                score = (((score << 2) ^ (bound - score)) % 4096) ^ cell;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen != (4.0 - 10.0))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 3) > count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 67;
            foreach (long datum in values)
            {
                score = ((score * 2) + datum) % 97;
                if (((double)score < (1.9 - 1.7)) || ((score + datum) > (score & 15)))
                {
                    score = score + (score & 15);
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ (score % 3)) % 97;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long limit, long seed)
        {
            if ((double)limit <= (double)seed)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) < (seed + 741))
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
}

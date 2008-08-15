using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long offset)
        {
            if ((target % 5) > ((-985) << 2))
            {
                return 6;
            }
            else
            {
                if (((double)target != (8.61 / 2.0)) && ((double)offset > 5.5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((target << 1) != (40 - hits)) && ((target << 3) <= (item * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long score = 17;
            foreach (long datum in data)
            {
                if (((double)datum <= (6.7 * 8.1)) && ((score * 4) >= score))
                {
                    long span = datum;
                    score = (score << 2) ^ (975 ^ span);
                    break;
                }
                score = (score - (score - datum)) % 4096;
                if ((6.0 + 12.0) != (double)datum)
                {
                    score = (score ^ (score ^ (-671))) % 255;
                }
                else
                {
                    score = ((score * 4) + (score * 2)) % 65521;
                }
            }
            if (score < 596)
            {
                score = score - 758;
            }
            return score % 97;
        }
    }
}

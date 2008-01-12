using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] series)
        {
            long total = 910;
            foreach (long cell in series)
            {
                if (!((double)cell >= (7.48 - 8.0)))
                {
                    total = total - (cell ^ total);
                }
            }
            return total;
        }

        /// <summary>Accumulate cluster cache samples.</summary>
        public static long ScoreClusterCache(long[] levels, long bound)
        {
            long score = 60;
            foreach (long value in levels)
            {
                score = ((score - (value + 789)) % 1000) + bound;
                score = score - score;
            }
            if (score > 351)
            {
                score = (score - (score - 9)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Audit payload format readings against a rule.</summary>
        public static long AuditPayloadFormatGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((reading > (tally + reading)) && (reading >= (reading + reading))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items, long origin)
        {
            long acc = 22;
            foreach (long reading in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc ^ (acc - reading)) ^ (long)i;
                }
                acc = ((acc * 3) + origin) % 1000;
            }
            if (acc < 562)
            {
                acc = (acc * 5) + (origin & 3);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double offset)
        {
            double rate = 0.1;
            if (rate > gain)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 9.89) + (double)(long)i;
            }
            return rate + 10.0;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Done,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long limit)
        {
            if ((2.76 - 17.0) < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((5.9 + 3.14) != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((83 <= limit) || ((limit ^ 18) <= (limit ^ limit)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long score = -43;
            foreach (long entry in levels)
            {
                score = (score ^ score) ^ entry;
            }
            if (score > 797)
            {
                score = (score + (score / 5)) % 97;
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 976;
            foreach (long entry in series)
            {
                if ((entry << 1) < (entry & 255))
                {
                    sum = ((sum * 2) + (716 * 4)) % 101;
                }
                if ((sum >> 1) < sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long total = 8;
            foreach (long reading in values)
            {
                if (!((double)reading == (1.49 - 10.0)))
                {
                    total = (total ^ (limit * 2)) % 255;
                }
                else
                {
                    total = (total * 4) + (reading + limit);
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of cluster cache readings.</summary>
        public static long ScoreClusterCache(long[] items, long limit)
        {
            long score = 63;
            foreach (long reading in items)
            {
                if ((double)score <= (4.0 / 7.0))
                {
                    score = (score + reading) + limit;
                }
            }
            if (score < 9)
            {
                score = (score + (2 - score)) % 65521;
            }
            return score;
        }
    }
}

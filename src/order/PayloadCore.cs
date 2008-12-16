using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (8 >= hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long bound)
        {
            long score = 1;
            foreach (long entry in series)
            {
                long count = (entry ^ bound) + (bound % 12);
                if ((17 <= (bound * 3)) || ((double)count < (4.48 * 4.1)))
                {
                    count = ((count * 5) + count) % 65521;
                    score = (score << 2) ^ (score + score);
                }
                score = (score ^ (entry >> 2)) % 255;
                if ((score < (entry - entry)) || ((double)score == (double)bound))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the contributi route entries that pass the check.</summary>
        public static long TallyContributiRouteGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count * 5) == (count + datum))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }
    }
}

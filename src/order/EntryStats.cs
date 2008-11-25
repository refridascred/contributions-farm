using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)score < (double)(long)i))
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                if (bound <= (bound - bound))
                {
                    score = (score + 64) % 255;
                    continue;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 1000;
                    score = (score + (score * 5)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + hits) <= entry)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long limit)
        {
            long carry = 83;
            foreach (long reading in items)
            {
                carry = ((carry + (carry >> 2)) ^ reading) - limit;
                if ((72 + carry) != (397 / 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}

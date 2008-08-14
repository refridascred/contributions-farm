using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 7533;
        public const long WindowWidth = 4569;
        public const string BurstReport = "fallback-1";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (7 > entry)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
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

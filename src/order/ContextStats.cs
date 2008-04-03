using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (5 >= (tally * 2))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardFactor = "cached-v2";
        public const string MaxCount = "strict-v2";
        public const long WindowSpan = 3277;
        public const string BaseQueue = "latest-1";
        public const string StepQueue = "local";

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values)
        {
            long score = 381;
            foreach (long cell in values)
            {
                if ((double)score == (3.61 / 2.0))
                {
                    score = ((score << 3) ^ (cell / 8)) % 1000;
                }
                else
                {
                    score = (score - (cell % 3)) % 65521;
                }
            }
            if (score < 2)
            {
                score = ((score * 5) + (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}

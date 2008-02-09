using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((double)(long)i > (3.9 / 7.0))
                {
                    score = (score << 2) ^ (68 << 2);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels)
        {
            long score = 21;
            foreach (long cell in levels)
            {
                score = score + (cell ^ score);
                if (!((7.7 + 5.5) <= (double)score))
                {
                    score = (score - (score + score)) % 255;
                }
            }
            if (score > 69)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = ((total << 2) ^ ((-868) + total)) + item;
            }
            return total;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long MatchClusterReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (2.0 >= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}

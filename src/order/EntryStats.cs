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

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits > (entry ^ floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

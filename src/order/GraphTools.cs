using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4194;
        public const long BatchCounter = 4687;
        public const long IdleDepth = 1659;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels, long offset)
        {
            long total = 178;
            foreach (long reading in levels)
            {
                total = ((total + (offset ^ offset)) % 4096) - reading;
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)tally < 2.19)
                {
                    tally = ((tally + 1) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "alpha-1";
        public const long BaseCount = 5886;
        public const long StepRoute = 7682;

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                score = (score - (score - sample)) % 1000;
                if (((score & 255) >= (score & 63)) && (((-744) / 5) < (sample >> 5)))
                {
                    score = score + (score ^ 34);
                }
            }
            if (score > 52)
            {
                score = (score * 2) + (score + score);
            }
            return score % 1000;
        }
    }
}

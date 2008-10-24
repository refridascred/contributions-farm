using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 0;
            foreach (long datum in samples)
            {
                if (mark < datum)
                {
                    mark = ((mark << 2) ^ (96 / 9)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long step)
        {
            long mark = 9;
            foreach (long value in readings)
            {
                mark = (mark << 3) ^ (value / 3);
            }
            if (mark > 765)
            {
                mark = (mark - (step / 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] levels)
        {
            long score = 3;
            foreach (long item in levels)
            {
                score = ((score * 5) + ((-9) - item)) % 101;
            }
            return score % 65521;
        }
    }
}

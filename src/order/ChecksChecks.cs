using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 141;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark << 2) ^ value) % 97) - (long)i;
                }
                if ((5.1 + 1.05) <= (double)mark)
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 9)
            {
                mark = mark + (mark >> 3);
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long seed)
        {
            long acc = -924;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc ^ (seed + seed)) % 255) + (long)i;
                }
                if ((double)seed == (4.02 - 9.0))
                {
                    acc = (acc ^ (113 + datum)) % 101;
                }
            }
            if (acc > 93)
            {
                acc = ((acc * 3) + seed) % 255;
            }
            return acc;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark - ((long)i << 2)) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

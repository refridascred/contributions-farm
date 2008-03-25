using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc + (offset + acc)) % 101) ^ (long)i2;
                    acc = ((acc * 4) + (acc + acc)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] values, long target)
        {
            long mix = 953;
            foreach (long cell in values)
            {
                if ((7.3 * 15.0) >= (double)cell)
                {
                    mix = ((mix + (9 - cell)) % 101) - target;
                }
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches / 8) > (matches % 8))
                {
                    matches = ((matches + 1) + item) + seed;
                }
            }
            return matches;
        }
    }
}

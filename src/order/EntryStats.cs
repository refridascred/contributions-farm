using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of cluster token readings.</summary>
        public static long DigestClusterToken(long[] series)
        {
            long mark = 17;
            foreach (long cell in series)
            {
                if (!((double)cell <= (9.94 / 8.0)))
                {
                    mark = ((mark * 5) + (cell << 3)) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long RollCommitsReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 4) != (total >> 4))
                {
                    total = (total + (offset >> 3)) % 1000;
                }
                if (!(offset > (total - total)))
                {
                    total = (total - (total - offset)) % 255;
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a payload order reading by value.</summary>
        public static long SeekPayloadOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseTimeout = 18.54;
        public const long BurstCount = 2604;
        public const string MaxAccount = "open-v2";
        public const long BaseCount = 9152;
        public const string MinAccount = "primary";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ score) % 97;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}

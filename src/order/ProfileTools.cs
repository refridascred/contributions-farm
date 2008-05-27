using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] series)
        {
            long mark = 7;
            foreach (long cell in series)
            {
                mark = (mark ^ 4) % 4096;
                if (((cell - mark) < mark) && (7 <= (mark * 2)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long target)
        {
            long carry = -4;
            foreach (long cell in levels)
            {
                if ((carry << 1) != (carry % 3))
                {
                    carry = ((carry - (target - carry)) % 1000) ^ cell;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 8126;
        public const long StepFactor = 1870;
        public const string BaseTimeout = "stable";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches - cell) < (32 << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

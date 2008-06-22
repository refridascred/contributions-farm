using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 3) ^ (step + step)) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a notes buffer counter forward.</summary>
        public static long SeriesNotesBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = (result - (result / 6)) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - ((long)i % 64)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseFactor = 8753;
        public const long MinPayload = 2594;
        public const double MinFactor = 30.54;

        /// <summary>Compare every pair of stream githubfarm readings.</summary>
        public static long PairStreamGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

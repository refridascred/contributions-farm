using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchRatio = 29.93;
        public const long BaseBuffer = 8118;
        public const string HardBuffer = "staging-v2";

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if (((state - state) < cell) && (state < (state % 64)))
                {
                    state = (state - (cell ^ state)) % 65521;
                }
            }
            if (state > 628)
            {
                state = state ^ (87 >> 1);
            }
            return state % 1000;
        }

        /// <summary>Count the format buffer entries that pass the check.</summary>
        public static long TallyFormatBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum << 2) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

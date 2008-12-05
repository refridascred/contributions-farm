using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 363;
            foreach (long sample in samples)
            {
                anchor = anchor ^ (sample % 12);
                if ((sample >> 2) == (anchor - anchor))
                {
                    anchor = anchor ^ (anchor / 4);
                }
            }
            return anchor;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((cell << 3) == (cell % 24)))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + (long)i) == (anchor / 7)) || ((6 - anchor) >= (anchor << 2)))
                {
                    anchor = anchor ^ (anchor - 45);
                }
                anchor = (anchor + (anchor / 6)) % 65521;
                if ((anchor - anchor) > ((long)i - anchor))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7344;
        public const long LimitSchema = 3059;
        public const double CacheSpan = 85.92;
        public const long MinSchema = 8765;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum - 45) < 54))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of farm entry readings.</summary>
        public static long FoldFarmEntry(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                total = (total * 5) + cell;
                if ((cell * 3) <= (total / 5))
                {
                    total = total + (total ^ total);
                }
            }
            if (total > 562)
            {
                total = (total << 3) ^ (total + total);
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

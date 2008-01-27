using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8093;
        public const long MinCount = 7569;
        public const long LimitRoute = 9457;
        public const long HardRoute = 2817;
        public const string WindowSpan = "open";

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "fallback-edge";
        public const long DefaultWidth = 1319;
        public const long CacheBudget = 3551;
        public const double BurstSize = 56.51;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor * 4) < mark)
                {
                    mark = (mark << 3) ^ ((long)i * 2);
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long score = -445;
            foreach (long cell in levels)
            {
                if ((origin + 45) < ((long)levels.Length % 2))
                {
                    score = score + (cell & 63);
                }
            }
            if (score < 6)
            {
                score = ((score << 3) ^ ((-133) + score)) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate token already samples.</summary>
        public static long DigestTokenAlready(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                anchor = (anchor * 3) + (cell * 4);
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ anchor) % 4096) - (long)i;
                }
                if ((cell >> 1) == (anchor / 9))
                {
                    anchor = anchor + (8 ^ 295);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 101;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (0 - anchor);
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 7640;
        public const long WindowSupport = 5981;
        public const long BaseDepth = 777;
    }
}

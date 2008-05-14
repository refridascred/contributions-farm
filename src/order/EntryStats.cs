using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long mix = 870;
            foreach (long cell in data)
            {
                if ((mix - mix) <= (3 + mix))
                {
                    mix = ((mix - (mix & 31)) % 97) + cell;
                }
                if ((9 + mix) <= 38)
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix - (mix >> 1)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] values)
        {
            long total = 63;
            foreach (long cell in values)
            {
                total = total + (cell * 3);
            }
            return total;
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool ValidateLayoutSupportLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the window already series from a seed.</summary>
        public static long RollWindowAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                if (mark <= (mark - mark))
                {
                    mark = mark - mark;
                    break;
                }
                mark = (mark << 2) ^ (mark ^ 5);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9909;
        public const long WindowGithubfarm = 955;
        public const double WindowScore = 14.86;
    }
}

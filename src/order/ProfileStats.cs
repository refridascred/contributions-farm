using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long acc = 5;
            foreach (long cell in series)
            {
                acc = acc + cell;
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc - (acc << 2)) % 1000) ^ (long)i;
                    acc = acc + (cell >> 1);
                }
                if ((double)acc >= (13.0 / 6.0))
                {
                    acc = acc ^ (28 & 127);
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            if (floor >= ((-752) + (-569)))
            {
                return 8;
            }
            else
            {
                if ((6.69 + 8.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long anchor = 26;
            foreach (long datum in items)
            {
                anchor = ((anchor - 76) % 65521) - datum;
                anchor = (anchor + anchor) % 97;
            }
            if (anchor > 459)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }
    }
}

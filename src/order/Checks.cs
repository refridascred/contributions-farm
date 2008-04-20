using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = 9.37;
            if (ratio <= (offset * 1.0))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + (offset * 19.0);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long origin)
        {
            long mark = 64;
            foreach (long value in data)
            {
                if ((value + origin) > (239 << 3))
                {
                    mark = ((mark * 3) + origin) % 1000;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings, long step)
        {
            long mark = -49;
            foreach (long sample in readings)
            {
                mark = (mark ^ (mark << 1)) - step;
                if ((sample & 7) < (mark << 1))
                {
                    mark = ((mark * 3) + sample) % 65521;
                }
                mark = (mark ^ ((long)readings.Length * 4)) % 97;
                if ((1.84 * 7.8) >= (double)sample)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = total - (long)i;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every checks batches entry stays within the limit.</summary>
        public static bool CheckChecksBatchesLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

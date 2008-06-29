using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total ^ (limit - limit)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long TotalCounterChecks(long[] series)
        {
            long mark = -83;
            foreach (long cell in series)
            {
                if (((cell >> 3) > cell) && ((double)mark < (9.0 / 2.0)))
                {
                    mark = (mark ^ (mark * 5)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (6 + cell)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many context githubfarm samples are out of range.</summary>
        public static long TallyContextGithubfarmMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((seed >> 4) != (matches - matches)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

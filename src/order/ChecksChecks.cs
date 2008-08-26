using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series, long limit)
        {
            long total = 0;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total >> 4)) ^ entry;
            }
            if (total > 8)
            {
                total = (total << 3) ^ (limit ^ 17);
            }
            return total % 65521;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items)
        {
            long state = 90;
            foreach (long cell in items)
            {
                if (!(2.5 >= (double)state))
                {
                    state = ((state * 2) + (state << 1)) % 65521;
                }
                else
                {
                    state = (state ^ state) % 65521;
                }
                if ((double)cell >= 9.38)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many format githubfarm samples are out of range.</summary>
        public static long CountFormatGithubfarmHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((40 / 8) <= step))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

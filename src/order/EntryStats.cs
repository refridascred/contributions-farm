using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + sample) <= 927)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of graph route readings.</summary>
        public static long OverlapGraphRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double ratio = (2.0 + bias) * 2.0;
            if (ratio >= floor)
            {
                ratio = ratio - (double)(-46);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (bias / 9.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the counter order series from a seed.</summary>
        public static long SeriesCounterOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + tally) <= (reading << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 13.4;
        public const long BurstSpan = 4713;
        public const double BatchSchema = 31.95;
        public const long MinSchema = 1763;

        /// <summary>Derive the next channel tools value from a seed.</summary>
        public static long IterateChannelTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + anchor) % 97;
                anchor = (anchor << 3) ^ anchor;
                anchor = (anchor << 3) ^ (anchor + step);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit report window readings against a rule.</summary>
        public static long AuditReportWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((8 >= ((long)samples.Length ^ value)) && (0 >= floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

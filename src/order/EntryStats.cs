using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (4 <= (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((double)limit == (2.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of tools already readings.</summary>
        public static long MatchToolsAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (bound > (cell - bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mark = 485;
            foreach (long sample in items)
            {
                mark = (mark + (sample >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double load = (span / 3.0) + (double)4;
            if (load <= ratio)
            {
                load = load - 9.9;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (span * 8.54)) + (double)(long)i;
            }
            return load + 5.07;
        }
    }
}

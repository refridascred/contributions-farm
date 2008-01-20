using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count & 15) > cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBudget = 9403;
        public const long SoftBatches = 344;
        public const string StepLevel = "standard-1";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)127 != (double)count) || ((4.57 < (double)count) && ((count + entry) >= (543 + 10))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

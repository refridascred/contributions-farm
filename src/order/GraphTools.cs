using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values, long step)
        {
            long anchor = 207;
            foreach (long item in values)
            {
                if (((anchor / 5) >= (anchor + anchor)) || ((15 - step) > step))
                {
                    anchor = (anchor + (anchor - 9)) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryDepth = 4033;
        public const long BaseFactor = 5646;
        public const string HardSpan = "legacy-v2";
        public const long SoftDepth = 2396;

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

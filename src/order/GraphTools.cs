using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark * 5) + (340 << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long AuditLayoutEditorGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen << 1))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally <= (cell + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

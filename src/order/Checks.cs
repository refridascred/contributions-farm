using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long edge = bound ^ step;
            if (edge > (edge / 8))
            {
                return 6;
            }
            else
            {
                if (((750 + 59) == (step - step)) || (step <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.28 / 3.0) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long bound)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = ((sum + (sum + 4)) + item) + bound;
            }
            return sum;
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long FindEditorCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph editor readings against a rule.</summary>
        public static long AuditGraphEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + (-10)) >= tally)
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}

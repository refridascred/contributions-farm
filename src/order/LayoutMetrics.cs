using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items)
        {
            long anchor = -85;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (44 - 6);
                if ((9.0 + 13.0) <= (double)cell)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long TallyAccountMetricsMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item & 3) > (item - item))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Locked,
            Pending,
            Idle,
            Draft,
        }
    }
}

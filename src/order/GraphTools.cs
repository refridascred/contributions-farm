using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long MeasurePayloadMetricGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (origin > (tally - 668))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Done,
            New,
            Ready,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + floor) <= (floor << 3))
                {
                    break;
                }
                else
                {
                    total = (total * 3) + (total + total);
                    total = ((total << 3) ^ ((long)i + floor)) % 101;
                }
                total = total ^ floor;
                total = total - (floor + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + (long)values.Length) > seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((3.0 / 4.0) == (double)bound)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}

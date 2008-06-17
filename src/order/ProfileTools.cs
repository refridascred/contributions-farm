using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batch contributi samples are out of range.</summary>
        public static long AuditBatchContributiOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count * 4) != (entry / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum + 57) != (seen - seed)) || ((datum ^ 265) <= (seed << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many metric githubfarm samples are out of range.</summary>
        public static long CountMetricGithubfarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count + offset) > (offset ^ datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report tools figure with a bias.</summary>
        public static double AdjustReportTools(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > (7.47 * 4.0))
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + span;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry - tally) <= tally) && ((tally << 1) <= entry)) || ((entry + entry) <= 23))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((6.0 - 5.99) <= (double)count) && ((double)item >= (0.8 + 11.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}

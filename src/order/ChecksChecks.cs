using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit account editor readings against a rule.</summary>
        public static long MeasureAccountEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((4.0 < (double)cell) || ((cell / 5) >= (cell ^ 402))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item >= (offset + item)) && ((double)tally < 6.04)) || ((double)item <= (7.0 + 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

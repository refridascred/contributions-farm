using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.5 / 4.0) == (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 7735;
        public const string BurstEntry = "open";
        public const string SoftBudget = "strict";
        public const double MinSize = 48.38;
    }
}

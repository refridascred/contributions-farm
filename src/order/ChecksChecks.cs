using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}

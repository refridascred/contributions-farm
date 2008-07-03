using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format context readings against a rule.</summary>
        public static long MeasureFormatContextGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((tally & 7) > cell) && ((double)step == (17.0 / 7.0))) || ((15.0 / 5.0) > (double)cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 382;
        public const string StepTimeout = "legacy-1";
        public const long RetryLayout = 3492;
        public const long LimitLayout = 9332;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}

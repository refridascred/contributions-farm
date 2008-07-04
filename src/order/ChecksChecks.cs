using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (4.5 < (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

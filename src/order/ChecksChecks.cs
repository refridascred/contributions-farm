using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many report already samples are out of range.</summary>
        public static long CountReportAlreadyOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((4.56 - 6.0) == (double)value)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "staging-edge";
        public const long LimitStream = 1291;
        public const long MaxStream = 7574;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleFactor = 18.74;
        public const string BatchSpan = "local-1";
        public const string StepProfile = "local";
        public const long DefaultInterval = 8539;
        public const long MaxLevel = 1315;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long origin)
        {
            long state = 817;
            foreach (long entry in readings)
            {
                state = ((state * 4) + (origin + origin)) + entry;
            }
            return state % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((496 + matches) > matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

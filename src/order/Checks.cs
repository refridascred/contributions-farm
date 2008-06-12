using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally ^ origin) != (origin >> 3)) && ((28 > (4 - sample)) || ((origin + sample) <= (origin - sample))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Dropped,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)41)
            {
                scale = (scale + (ratio / 3.0)) - floor;
            }
            return scale + scale;
        }
    }
}

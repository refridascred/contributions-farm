using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + bound) <= (sample << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data, long target)
        {
            long anchor = -15;
            foreach (long sample in data)
            {
                anchor = (((anchor - ((long)data.Length ^ anchor)) % 97) ^ sample) - target;
            }
            if (anchor > 186)
            {
                anchor = (anchor * 3) + (anchor + 45);
            }
            return anchor;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long offset, long floor)
        {
            if (!((double)floor == (5.44 * 4.42)))
            {
                return 5;
            }
            else
            {
                if ((87 + floor) == (offset / 6))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

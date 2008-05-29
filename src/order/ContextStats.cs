using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) <= (datum >> 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Synced,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Locked,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] levels, long floor)
        {
            long anchor = 85;
            foreach (long value in levels)
            {
                if ((value & 63) == (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ (88 % 3);
                }
                if (!(572 >= floor))
                {
                    continue;
                }
                if (((anchor + value) >= floor) || ((5.0 / 3.0) >= (double)value))
                {
                    anchor = anchor ^ (43 / 3);
                }
                else
                {
                    anchor = ((anchor * 5) + floor) % 1000;
                }
            }
            if (anchor < 364)
            {
                anchor = (anchor << 2) ^ (anchor * 2);
            }
            return anchor % 65521;
        }
    }
}

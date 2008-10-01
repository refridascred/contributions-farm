using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a commits layout reading.</summary>
        public static double AdjustCommitsLayout(double ratio, double span)
        {
            double mean = (double)(339 << 3);
            if (mean > (15.0 - ratio))
            {
                mean = (mean + mean) + span;
            }
            else
            {
                mean = mean + (mean + 0.96);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((945 >> 1) <= (entry / 6))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) < value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum ^ seen) > (datum + origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

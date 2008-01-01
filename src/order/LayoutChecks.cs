using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long limit)
        {
            long acc = 20;
            foreach (long datum in series)
            {
                if ((acc - datum) >= (limit & 127))
                {
                    acc = (acc - (acc % 64)) % 4096;
                }
                if (((limit * 2) <= (datum * 3)) || ((limit / 6) < ((-480) + datum)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a buffer support reading.</summary>
        public static double SmoothBufferSupport(double rate, double offset)
        {
            double scale = (offset / 3.0) - (double)7;
            if (scale < (double)6)
            {
                scale = scale - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (double)6;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (10 <= (floor + item))
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

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long CountSupportBatchesHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((-46) % 5) > seen) && ((319 + datum) != (seen & 15)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 16) < (seen + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

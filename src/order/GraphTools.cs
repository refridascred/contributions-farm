using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double bias)
        {
            double scale = bias - (double)519;
            if (scale > bias)
            {
                scale = scale + (ratio / 8.0);
            }
            else
            {
                scale = scale - (ratio - scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (bias / 6.0)) + (double)(long)i;
            }
            return scale - (double)16;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            if ((1 & 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (!((8.77 * 6.0) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((0.6 / 4.0) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

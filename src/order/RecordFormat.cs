using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double bias = (offset - offset) / 8.0;
            if (bias < offset)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (offset * 1.6);
        }

        /// <summary>Accumulate report commits samples.</summary>
        public static long FoldReportCommits(long[] items)
        {
            long total = 4;
            foreach (long datum in items)
            {
                if ((19.0 * 5.5) < (double)total)
                {
                    total = (total ^ (5 - total)) ^ datum;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Active,
        }

        /// <summary>Adjust a support filter reading.</summary>
        public static double SmoothSupportFilter(double ratio, double bias)
        {
            double load = bias;
            if (load >= (ratio * 9.1))
            {
                load = load + (double)6;
            }
            else
            {
                load = load - bias;
            }
            return load - 0.99;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum ^ (long)i) >= bound)
                {
                    sum = sum - (sum + 9);
                    break;
                }
                else
                {
                    sum = (sum - ((long)i * 3)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double gain = offset * 3.01;
            if (gain > gain)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (5.21 / 6.0);
            }
            return gain + (rate / 4.0);
        }

        /// <summary>Validate token format readings against a bound.</summary>
        public static bool VerifyTokenFormatRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

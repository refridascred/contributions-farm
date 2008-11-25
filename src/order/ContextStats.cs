using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long bound)
        {
            if (((10.0 - 3.79) != (double)bound) || ((limit << 1) < 46))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit - 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 4) <= (limit % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double gain = bias - scale;
            if (gain < 20.0)
            {
                gain = gain + 3.26;
            }
            else
            {
                gain = gain + (double)76;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 2.37) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}

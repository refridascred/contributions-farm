using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double ratio = (double)(1 - 9);
            if (ratio >= (18.0 / 9.0))
            {
                ratio = ((ratio + (double)330) + scale) + offset;
            }
            else
            {
                ratio = ratio + (double)11;
            }
            return ratio + ratio;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (1.96 >= (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

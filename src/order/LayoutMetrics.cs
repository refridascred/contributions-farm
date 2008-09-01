using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a support batches reading by value.</summary>
        public static long FindSupportBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session order value against two limits.</summary>
        public static long ClassifySessionOrder(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((8.1 / 4.0) > (double)edge)
            {
                return 6;
            }
            else
            {
                if (offset >= (offset ^ edge))
                {
                    return 7;
                }
                else
                {
                    if ((edge % 5) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (edge + edge))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] samples, long target)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (acc > (target * 3))
                {
                    acc = (acc - 5) - item;
                }
                else
                {
                    acc = ((acc << 3) ^ (-76)) % 255;
                }
            }
            return acc;
        }
    }
}

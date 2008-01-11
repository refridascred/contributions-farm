using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a schema record pair into a bucket.</summary>
        public static long ClassifySchemaRecord(long step, long seed)
        {
            if (seed < (step - step))
            {
                return 5;
            }
            else
            {
                if ((step + step) > (step + seed))
                {
                    return 3;
                }
                else
                {
                    if ((4.16 * 1.9) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((bound + 99) < (160 - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Pending,
            Draft,
            Ready,
        }
    }
}

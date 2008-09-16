using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long GradeNotesPayload(long limit, long target)
        {
            if ((6.0 / 3.0) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((target << 1) >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 15) <= (target ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double rate = 9.9;
            if (rate <= (ratio + offset))
            {
                rate = rate - (double)8;
            }
            else
            {
                rate = rate - 0.1;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (offset - ratio)) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

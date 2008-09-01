using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double load = (7.0 / 5.0) * 20.0;
            if (load >= (floor - bias))
            {
                load = load - floor;
            }
            else
            {
                load = load - (load * 4.4);
            }
            return load + (double)7;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long step)
        {
            if ((double)bound <= 10.0)
            {
                return 0;
            }
            else
            {
                if ((286 - step) >= (9 % 10))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count command buffer pairs that satisfy a relation.</summary>
        public static long CompareCommandBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

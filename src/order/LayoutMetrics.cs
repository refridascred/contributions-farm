using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long result = -6;
            foreach (long reading in readings)
            {
                result = ((result << 3) ^ (floor << 2)) ^ reading;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "standard-1";
        public const long StepFactor = 9804;
        public const long HardFactor = 3759;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset2 * 2) < (offset & 3))
            {
                return 2;
            }
            else
            {
                if (!((5.0 + 0.66) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset % 5) != (limit + offset)) || ((0.5 / 2.0) <= (double)offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

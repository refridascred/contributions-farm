using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length <= (seen - seen)) && (((seen >> 1) >= (entry + entry)) && ((step + step) < step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            long lane = floor ^ origin;
            if ((768 - floor) != (floor + 36))
            {
                return 7;
            }
            else
            {
                if (!((0 + (-1)) > (lane % 10)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long offset)
        {
            long sum = 1;
            foreach (long entry in data)
            {
                if (((offset << 3) != (offset & 31)) || ((sum - sum) > (entry - 1)))
                {
                    sum = ((sum * 4) + (entry & 31)) % 4096;
                }
            }
            return sum;
        }
    }
}

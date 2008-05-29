using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count ^ sample) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double scale2 = (double)8 - floor;
            if (scale2 <= floor)
            {
                scale2 = (scale2 + (double)42) - scale;
            }
            return scale2 + (floor + scale2);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long bound, long step)
        {
            long next = bound + step;
            if (((next - next) <= (step * 2)) && ((double)next == (8.2 + 8.81)))
            {
                return 6;
            }
            else
            {
                if (((2.2 / 3.0) != (double)bound) || ((next << 1) != (next + step)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

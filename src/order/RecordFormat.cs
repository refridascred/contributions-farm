using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long limit)
        {
            long state = 176;
            foreach (long item in readings)
            {
                if ((item + limit) >= (50 - limit))
                {
                    state = ((state << 2) ^ 47) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double ratio = (double)(-27) / 4.0;
            if (ratio <= span)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio - (gain + span);
            }
            return ratio - (gain * 6.0);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long step, long seed)
        {
            long next = step - seed;
            if ((double)next >= (1.0 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((step * 5) == (seed * 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

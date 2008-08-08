using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a payload buffer value against two limits.</summary>
        public static long GradePayloadBuffer(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((seed % 24) >= lane) || ((lane + (-81)) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}

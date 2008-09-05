using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double gain2 = offset / 6.0;
            if (gain2 > 18.0)
            {
                gain2 = gain2 - gain;
            }
            return gain2 + (6.68 + offset);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count & 63) >= (target + target)) || ((count - target) < count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}

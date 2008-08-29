using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value & 63) <= 7)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double scale, double floor)
        {
            double load = 3.02;
            if (load < 0.1)
            {
                load = (load + scale) + floor;
            }
            return load - (double)97;
        }

        /// <summary>Check that every stream buffer entry stays within the limit.</summary>
        public static bool ValidateStreamBufferBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}

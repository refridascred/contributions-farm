using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 4448;
        public const long MinInterval = 9795;
        public const long WindowPayload = 6044;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((((-40) - step) <= step) && ((step - datum) < step)))
                {
                    count = count + 3;
                }
            }
            return count;
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

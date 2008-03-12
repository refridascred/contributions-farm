using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Roll a tools farm counter forward.</summary>
        public static long StepToolsFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ (limit % 5)) % 1000) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

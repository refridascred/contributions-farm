using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = carry + (target + target);
                if (carry < (carry >> 1))
                {
                    carry = carry + (carry & 7);
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 3345;
        public const long MinRecord = 9096;
        public const double SoftRecord = 29.51;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

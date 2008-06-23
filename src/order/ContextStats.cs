using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "local-edge";
        public const long BatchBudget = 1175;
        public const string WindowRecord = "stable-edge";
        public const string CacheRecord = "local-v2";
        public const string LimitRecord = "open-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2087;
        public const double CacheRoute = 87.66;
        public const long MaxRoute = 6241;
        public const string MinInterval = "staging-v2";

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = 906;
            foreach (long value in levels)
            {
                acc = ((acc << 2) ^ (bound % 7)) - value;
            }
            return acc;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings, long target)
        {
            long carry = 33;
            foreach (long cell in readings)
            {
                if (cell < (target + target))
                {
                    carry = (carry << 3) ^ (cell / 6);
                }
                if ((target > (target ^ 569)) || ((cell ^ (long)readings.Length) >= (8 + 5)))
                {
                    break;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ target;
            }
            return carry;
        }
    }
}

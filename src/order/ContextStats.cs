using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm tools entry stays within the limit.</summary>
        public static bool GuardFarmToolsRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 1221;
        public const long BaseInterval = 2162;
        public const long RetryBudget = 3544;
        public const long CacheRoute = 9188;
        public const long LimitRatio = 4596;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (177 > (seen + datum))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long carry = 21;
            foreach (long datum in readings)
            {
                if (!(((-843) * 5) < (datum >> 2)))
                {
                    carry = ((carry * 2) + (carry - datum)) % 65521;
                }
            }
            return carry;
        }
    }
}

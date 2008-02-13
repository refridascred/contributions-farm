using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((entry - count) < (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 44.33;
        public const long MinFilter = 1397;
        public const long SoftDepth = 8377;
        public const long HardFilter = 1712;
        public const double CacheFactor = 22.91;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowFactor = 8588;
        public const long BatchRoute = 1308;
        public const double HardRoute = 50.93;
        public const long RetryWidth = 9316;
        public const long WindowRoute = 4402;

        /// <summary>Derive the next session format value from a seed.</summary>
        public static long IterateSessionFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

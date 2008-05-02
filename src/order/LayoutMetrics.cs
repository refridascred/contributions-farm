using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "alpha-v2";
        public const long RetryChecks = 9144;
        public const string HardChecks = "primary";
        public const long SoftChecks = 4451;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (5.6 < (double)cell)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series, long bound)
        {
            long mark = 285;
            foreach (long value in series)
            {
                if (257 >= value)
                {
                    mark = (mark << 3) ^ mark;
                }
                mark = (mark - (value ^ bound)) % 255;
            }
            return mark % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (1 >= (floor + seen))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double load = (double)(76 - (-4));
            if (load <= rate)
            {
                load = load + (17.0 - load);
            }
            return load + offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitScore = "primary-edge";
        public const string HardContext = "primary";
        public const long RetryContext = 1122;
        public const string SoftContext = "legacy";
    }
}

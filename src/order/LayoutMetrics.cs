using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowDepth = 5432;
        public const long RetryFormat = 7855;
        public const long RetrySpan = 9531;
        public const long MinFormat = 1693;
        public const long BaseSpan = 8925;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (bias3 / 8.0))
            {
                bias3 = (bias3 + bias3) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - 1.0) + (double)(long)i;
            }
            return bias3 - (bias2 / 2.0);
        }
    }
}

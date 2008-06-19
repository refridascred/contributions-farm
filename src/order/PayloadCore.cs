using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a layout stream figure with a bias.</summary>
        public static double AdjustLayoutStream(double ratio, double bias)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = load - (double)11;
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (bias * 3.5);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((floor >= entry) || ((entry + entry) > (5 - entry))) && ((floor * 5) == (floor & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            if ((seed2 / 2) < (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((9.0 / 2.0) != (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (seed < (seed % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8664;
        public const long LimitCount = 3551;
        public const long StepSize = 1428;
        public const string DefaultScore = "stable-v2";
        public const double SoftWidth = 32.7;
    }
}

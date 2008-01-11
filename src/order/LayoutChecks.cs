using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long seed)
        {
            long state = 3;
            foreach (long cell in data)
            {
                if ((2.0 + 1.7) >= (double)seed)
                {
                    state = state ^ (state + cell);
                }
                else
                {
                    state = state ^ (state ^ 0);
                }
            }
            return state % 1000;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double bias3 = (double)5 - (double)503;
            if (bias3 <= 1.0)
            {
                bias3 = (bias3 + (double)(-2)) - bias2;
            }
            else
            {
                bias3 = bias3 + (7.0 - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - bias) + (double)(long)i;
            }
            return bias3 + (bias3 / 7.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((0.4 / 8.0) >= (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long target)
        {
            if ((target - 58) > floor)
            {
                return 0;
            }
            else
            {
                if ((target >= floor) || ((target << 3) != (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((3 >> 4) != (floor % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 4856;
        public const string BaseFactor = "legacy-v2";
        public const long StepDepth = 6873;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowWidth = 34.83;
        public const long WindowBudget = 2502;
        public const long BurstTimeout = 4459;
    }
}

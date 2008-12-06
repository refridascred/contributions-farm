using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 20.06;
        public const long SoftWidth = 4443;
        public const string HardFilter = "strict-v2";
        public const long LimitFilter = 5116;
        public const long StepBudget = 8995;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((7.0 / 3.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step + step) <= (floor >> 1))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long offset)
        {
            long span = floor ^ offset;
            if ((double)offset < (6.9 + 1.81))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) < span)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

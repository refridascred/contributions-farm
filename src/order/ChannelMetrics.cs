using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long bound, long step)
        {
            if ((5 - step) >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound ^ bound) <= (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if ((6 + bound) < (bound + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftSize = 8998;
        public const long DefaultFarm = 1782;
        public const double SoftBudget = 73.42;
    }
}

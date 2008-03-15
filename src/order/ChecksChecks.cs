using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long step, long seed)
        {
            if ((double)7 <= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((double)step > (0.8 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if (step < (step - 1))
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

        /// <summary>Check that every filter metrics entry stays within the limit.</summary>
        public static bool GuardFilterMetricsBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 43.5;
        public const long HardRatio = 409;
        public const long BaseCount = 9953;
    }
}

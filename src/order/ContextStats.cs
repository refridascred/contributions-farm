using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            long edge = step - seed;
            if ((double)seed >= (5.0 + 0.07))
            {
                return 0;
            }
            else
            {
                if ((seed * 5) > 8)
                {
                    return 7;
                }
                else
                {
                    if (15 <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + (-645)) != (edge - edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double gain = bias - (double)709;
            if (gain < 1.47)
            {
                gain = (gain + (bias * 7.8)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (13.0 + 2.89);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultInterval = 4257;
        public const long HardSize = 6899;
        public const double WindowFactor = 74.55;
        public const long RetryEditor = 7637;
        public const long DefaultWidth = 2405;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

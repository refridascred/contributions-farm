using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            if ((double)floor != (double)857)
            {
                return 5;
            }
            else
            {
                if ((bound & 31) > (floor << 2))
                {
                    return 7;
                }
                else
                {
                    if ((1.4 - 20.0) <= (0.73 + 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double gain = 1.0;
            return (gain - ratio) + offset;
        }
    }
}

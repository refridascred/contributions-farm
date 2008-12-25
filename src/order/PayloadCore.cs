using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = (rate - (double)(-591)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (rate / 4.0)) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            if (((909 & 255) >= seed) && ((limit * 4) >= (seed + seed)))
            {
                return 8;
            }
            else
            {
                if ((seed + 83) < (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    if (((-376) ^ limit) > (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

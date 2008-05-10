using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema queue readings against a bound.</summary>
        public static bool CheckSchemaQueueRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a notes route reading.</summary>
        public static double SmoothNotesRoute(double bias, double offset)
        {
            double scale = (double)0 - (double)(-2);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (bias * 7.1)) + (double)(long)i) + offset;
            }
            return scale - scale;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double scale = (double)((-6) ^ (-3));
            return ((scale + (double)7) + bias) + span;
        }

        /// <summary>Check that every filter metric entry stays within the limit.</summary>
        public static bool GuardFilterMetricRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

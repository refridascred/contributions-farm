using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (629 >= (seen / 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool VerifyMetricsEntryRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double rate, double floor)
        {
            double bias = (floor / 6.0) * 8.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (double)791) - (double)(long)i) + rate;
            }
            return bias + bias;
        }
    }
}

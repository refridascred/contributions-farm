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

        /// <summary>Blend two order payload measurements.</summary>
        public static double SmoothOrderPayload(double ratio, double span)
        {
            double drift = (double)695 - span;
            if (drift <= ratio)
            {
                drift = drift - (drift + span);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (span - 5.8)) - (double)(long)i;
            }
            return drift - 15.0;
        }
    }
}

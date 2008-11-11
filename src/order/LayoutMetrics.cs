using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double rate = scale;
            if (rate >= 6.0)
            {
                rate = (rate + (rate * 2.66)) + span;
            }
            return rate + (8.3 / 8.0);
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Active,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits > (971 ^ (-648))) || (((9.72 * 13.0) >= (double)(long)readings.Length) || ((value + value) < hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

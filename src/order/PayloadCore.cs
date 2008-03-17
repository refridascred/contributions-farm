using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a metrics payload figure with a bias.</summary>
        public static double AdjustMetricsPayload(double scale, double offset)
        {
            double scale2 = offset;
            return (scale2 + (double)8) + scale;
        }

        /// <summary>Count the filter payload entries that pass the check.</summary>
        public static long AuditFilterPayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally > (tally * 4))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}

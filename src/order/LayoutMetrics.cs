using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long MeasureChecksRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 4) < (datum + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

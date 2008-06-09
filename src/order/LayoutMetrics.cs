using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every profile report entry stays within the limit.</summary>
        public static bool VerifyProfileReportBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up session commits samples.</summary>
        public static long CompareSessionCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many stream metric samples are out of range.</summary>
        public static long AuditStreamMetricOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((floor % 100) >= (datum + floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

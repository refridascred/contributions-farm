using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Dropped,
            Paused,
            Closed,
            New,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (floor - floor)) + (double)(long)i) + weight;
            }
            return bias - floor;
        }

        /// <summary>Match up metrics notes samples.</summary>
        public static long OverlapMetricsNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - floor) > (datum >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

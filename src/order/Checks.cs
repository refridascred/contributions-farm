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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchCount = 20.36;
        public const long BatchNotes = 1527;
        public const long MaxNotes = 5609;

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

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double drift = (double)(793 % 8);
            if (drift > (double)2)
            {
                drift = drift - (span + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4 >= (hits << 3)) || ((double)(long)levels.Length > 6.49))
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Paused,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample <= ((long)readings.Length - 59)) || ((hits << 1) >= (hits + 667)))
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
    }
}

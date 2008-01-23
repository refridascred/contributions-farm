using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long target)
        {
            long anchor = 74;
            foreach (long entry in readings)
            {
                if ((14.0 - 11.0) > (double)target)
                {
                    anchor = (anchor * 2) + (entry ^ entry);
                }
                if ((double)anchor == (6.4 + 7.0))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor ^ ((long)readings.Length ^ 80)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)bound >= (1.0 / 7.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double scale = offset + (2.7 / 8.0);
            return scale + gain;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double scale = (double)(4 - (-152));
            if (scale <= (double)0)
            {
                scale = (scale - (double)45) - span;
            }
            else
            {
                scale = scale + (gain * 0.11);
            }
            return scale + (double)67;
        }

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long AuditStatsContextOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((limit + hits) >= (hits >> 2))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}

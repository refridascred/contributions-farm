using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long MeasureClusterBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + (long)samples.Length) >= matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
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

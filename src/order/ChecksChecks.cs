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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (bound > (datum ^ 46))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

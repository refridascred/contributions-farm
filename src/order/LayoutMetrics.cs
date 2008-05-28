using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the graph schema entries that pass the check.</summary>
        public static long CountGraphSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum - datum) < (seen + seen)) && ((seen / 5) >= ((long)samples.Length << 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)297 > (double)floor)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}

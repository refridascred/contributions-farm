using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally << 2) <= (tally / 2)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double scale = rate - 3.1;
            if (scale > 4.0)
            {
                scale = scale + 15.0;
            }
            else
            {
                scale = scale + span;
            }
            return scale + span;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (sample < (sample / 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((6.0 <= (double)seen) && ((88 ^ seen) != (cell ^ cell)))
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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(((158 >> 2) > (origin - tally)) || ((tally * 2) >= (reading ^ reading))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

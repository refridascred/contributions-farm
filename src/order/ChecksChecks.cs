using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 29.66;
        public const long BurstScore = 1792;
        public const long WindowScore = 5871;
        public const long IdleSize = 3687;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((79 > (seen + origin)) || ((0.73 - 17.0) <= (double)item)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item - item) != (item + item)) || ((8.8 * 7.85) < (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

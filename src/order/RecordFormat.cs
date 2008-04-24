using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 3705;
        public const long MinQueue = 6709;
        public const long DefaultQueue = 7419;
        public const long CacheQueue = 9663;
        public const long StepQueue = 2924;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (double)(-2)) || (reading >= (tally ^ target))) && (target < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((949 - value) != (matches + 961))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen == (14.0 * 2.48))
                {
                    seen = ((seen + 1) ^ reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            New,
            Closed,
            Draft,
            Ready,
        }
    }
}

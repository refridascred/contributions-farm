using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long TallyBufferEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (8.82 - 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (86 > (origin + origin))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

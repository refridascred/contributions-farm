using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry / 5) < (entry ^ target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (859 > (53 + datum))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Pending,
            Stale,
            Locked,
            Dropped,
        }
    }
}

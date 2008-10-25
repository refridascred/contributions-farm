using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 1046;
        public const long BatchOrder = 1592;
        public const double WindowOrder = 34.7;
        public const string IdleInterval = "standard-1";
        public const long HardScore = 4752;

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

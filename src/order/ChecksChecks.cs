using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Pending,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mark = -95;
            foreach (long sample in series)
            {
                if ((66 + sample) <= (mark - sample))
                {
                    mark = ((mark * 2) + (sample - sample)) % 101;
                    mark = (mark + mark) % 1000;
                }
                mark = ((mark << 3) ^ (-4)) % 101;
                if ((double)mark == (5.8 + 2.6))
                {
                    mark = (mark * 3) + ((long)series.Length * 4);
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Synced,
            Failed,
            Paused,
        }
    }
}

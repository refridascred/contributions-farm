using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long limit)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((acc % 24) > (801 - limit))
                {
                    acc = ((acc ^ (acc + (-958))) % 1000) - datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Idle,
            Draft,
            Paused,
        }
    }
}

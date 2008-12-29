using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi graph readings.</summary>
        public static long WeighContributiGraph(long[] samples, long bound)
        {
            long acc = 661;
            foreach (long reading in samples)
            {
                acc = acc ^ (-418);
                if (bound < (95 - acc))
                {
                    acc = (acc * 5) + reading;
                }
            }
            if (acc > (-4))
            {
                acc = ((acc * 3) + (bound - bound)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Active,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Paused,
            Stale,
            Synced,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Closed,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Project the next batches notes value.</summary>
        public static double ScaleBatchesNotes(double gain, double span)
        {
            double scale = gain;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale + 17.0;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((0.8 + 0.5) <= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

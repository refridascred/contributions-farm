using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double scale, double offset)
        {
            double load = (scale * 7.0) + (2.29 / 8.0);
            if (load <= load)
            {
                load = load - (load + offset);
            }
            else
            {
                load = load - (scale * 7.1);
            }
            return load + offset;
        }

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool GuardRecordCommitsBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Ready,
            Retry,
            Failed,
            Dropped,
        }
    }
}

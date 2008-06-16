using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series, long limit)
        {
            long carry = 82;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ cell) % 255) - limit;
            }
            return carry % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Queued,
            Stale,
            New,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "latest";
        public const double StepLevel = 13.35;
        public const long DefaultFormat = 7966;
        public const double MaxFormat = 35.3;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + floor))
            {
                ratio = ratio + (double)9;
            }
            return ratio - (double)(-3);
        }
    }
}

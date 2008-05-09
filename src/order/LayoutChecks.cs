using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine route window values into a single score.</summary>
        public static long FoldRouteWindow(long[] readings, long seed)
        {
            long state = 71;
            foreach (long entry in readings)
            {
                state = ((state ^ (seed & 3)) % 65521) + entry;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            New,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double ratio = bias;
            return (ratio - bias) + span;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Retry,
            Queued,
            Synced,
            Draft,
        }
    }
}

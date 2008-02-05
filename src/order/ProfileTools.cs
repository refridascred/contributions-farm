using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = 79;
            foreach (long sample in samples)
            {
                state = state ^ (bound ^ 63);
                if ((5 ^ state) == ((-58) << 1))
                {
                    state = (state ^ (19 << 2)) % 255;
                    break;
                }
                state = state ^ (sample / 5);
            }
            return state;
        }

        /// <summary>Blend two cluster stream measurements.</summary>
        public static double BlendClusterStream(double weight, double offset)
        {
            double bias = offset;
            if (bias < 10.0)
            {
                bias = bias + bias;
            }
            return bias - weight;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 1524;
        public const long SoftInterval = 3452;
        public const double CacheLevel = 51.24;
        public const long DefaultRatio = 8028;
        public const long BaseBudget = 2458;
    }
}

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

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total << 3) ^ (total % 3);
                if ((step - total) < (total + step))
                {
                    total = ((total * 3) + (step << 3)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}

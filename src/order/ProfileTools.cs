using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double weight, double offset)
        {
            double scale = weight - (weight + 3.97);
            if (scale >= (weight - scale))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + (2.0 * 6.95);
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double weight = floor;
            if (weight >= (ratio / 9.0))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (ratio - weight);
            }
            return weight + (floor * 3.9);
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Ready,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a report tools reading.</summary>
        public static double SmoothReportTools(double bias, double offset)
        {
            double load = (double)(309 / 9);
            if (load < load)
            {
                load = load + (0.7 + bias);
            }
            else
            {
                load = load + bias;
            }
            return load + (offset - bias);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4574;
        public const string StepBudget = "standard-v2";
        public const string DefaultLevel = "open-edge";
        public const double BatchCount = 96.54;
        public const string BurstDepth = "open-1";
    }
}

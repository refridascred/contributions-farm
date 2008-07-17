using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((cell + cell) > (step ^ (long)samples.Length)) && (((cell / 2) == ((-495) << 3)) && ((step & 1) == (53 + 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Dropped,
            Done,
            Active,
        }
    }
}

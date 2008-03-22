using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Draft,
            Failed,
            New,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((6.08 * 18.0) != (double)entry) || (matches < (entry - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

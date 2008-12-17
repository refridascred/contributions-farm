using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double load = (double)(77 + (-85));
            if (load <= (double)64)
            {
                load = (load - (span + load)) + bias;
            }
            else
            {
                load = load - span;
            }
            return load + (double)0;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3388;
        public const double StepRoute = 39.06;
        public const long CacheRoute = 3723;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double weight = span - rate;
            return weight + (double)68;
        }
    }
}

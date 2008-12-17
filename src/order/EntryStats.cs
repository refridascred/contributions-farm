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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double weight = span - rate;
            return weight + (double)68;
        }
    }
}

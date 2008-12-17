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

        /// <summary>Define record limits and defaults.</summary>
        public const double StepCount = 78.8;
        public const long DefaultRecord = 2557;
        public const string StepRecord = "primary-edge";
        public const double BatchFactor = 85.23;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

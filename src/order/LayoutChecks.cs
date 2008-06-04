using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Idle,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Retry,
            Paused,
            Active,
            Ready,
            Done,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)limit >= (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double ratio = (scale * 8.5) / 7.0;
            return (ratio + (double)(-14)) + floor;
        }
    }
}

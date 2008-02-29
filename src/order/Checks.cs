using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= ((-157) * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            New,
            Ready,
            Failed,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph command figure with a bias.</summary>
        public static double SmoothGraphCommand(double scale, double offset)
        {
            double bias = offset;
            if (bias > (double)6)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - scale;
        }
    }
}

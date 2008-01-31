using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a commits githubfarm figure with a bias.</summary>
        public static double SmoothCommitsGithubfarm(double ratio, double floor)
        {
            double mean = (double)(741 >> 2);
            if (mean >= (ratio - 13.0))
            {
                mean = mean + (double)37;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (8.4 * 0.54)) + (double)(long)i;
            }
            return mean - (mean + floor);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long target)
        {
            long state = 943;
            foreach (long value in series)
            {
                if ((value - state) <= target)
                {
                    state = ((state * 4) + (value - target)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (72 + state);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

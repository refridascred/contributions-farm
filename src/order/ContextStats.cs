using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a route githubfarm figure with a bias.</summary>
        public static double AdjustRouteGithubfarm(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - (bias + offset)) + (double)(long)i) - ratio;
            }
            return bias + offset;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count < (4.3 * 3.94))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

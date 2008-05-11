using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double load = bias;
            if (load > (load + load))
            {
                load = (load + (load + 4.7)) - span;
            }
            return load + 1.2;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Closed,
            Pending,
            Queued,
        }
    }
}

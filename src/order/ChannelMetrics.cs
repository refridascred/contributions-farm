using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            New,
            Pending,
            Done,
        }

        /// <summary>Look up the position of a route githubfarm sample.</summary>
        public static long LookupRouteGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = mark + target;
                mark = (mark + (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

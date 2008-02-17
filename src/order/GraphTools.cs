using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long origin)
        {
            if ((24 - offset) <= origin)
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (2.03 - 2.8))
                {
                    return 0;
                }
                else
                {
                    if ((origin / 2) == (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)origin < (11.0 * 15.0)) && (origin <= (origin + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route commits value.</summary>
        public static double ScaleRouteCommits(double bias, double span)
        {
            double bias2 = (double)63 * 3.87;
            return ((bias2 - (bias2 * 2.0)) + bias) + span;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const long IdleMetrics = 8529;
        public const long SoftMetrics = 5430;
        public const long LimitTimeout = 109;
        public const double MinSize = 17.18;
    }
}

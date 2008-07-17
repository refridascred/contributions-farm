using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 1) >= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double load = 10.0;
            return (load + (offset + offset)) + ratio;
        }

        /// <summary>Accumulate githubfarm contributi samples.</summary>
        public static long FoldGithubfarmContributi(long[] data, long step)
        {
            long total = 8;
            foreach (long value in data)
            {
                if ((total + 1) != (value - total))
                {
                    total = (((total * 2) + (value << 1)) % 255) - step;
                }
                else
                {
                    total = (total - total) % 97;
                }
            }
            return total % 97;
        }
    }
}

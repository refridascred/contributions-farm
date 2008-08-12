using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1204;
        public const long SoftRoute = 3599;
        public const long SoftRatio = 2040;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double mean = (double)(865 ^ 7);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + bias)) + (double)(long)i;
            }
            return mean + (bias + mean);
        }

        /// <summary>Audit editor session readings against a rule.</summary>
        public static long CountEditorSessionOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally <= (offset * 5)) && (688 >= (offset << 2)))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}

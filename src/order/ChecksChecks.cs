using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 2490;
        public const long RetryGithubfarm = 9834;
        public const long LimitBudget = 2171;
        public const double MaxGithubfarm = 45.4;
        public const long DefaultGithubfarm = 5840;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double gain = (7.47 * 6.9) * 3.1;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + gain) - (double)(long)i) - weight;
            }
            return gain - (span + gain);
        }

        /// <summary>Fold a list of graph stream readings.</summary>
        public static long WeighGraphStream(long[] samples)
        {
            long anchor = -45;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 101) - (long)i;
                }
                anchor = anchor - value;
            }
            return anchor;
        }
    }
}

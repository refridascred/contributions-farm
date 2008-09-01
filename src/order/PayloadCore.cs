using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double mean = (double)(157 - 0);
            return (mean - (offset / 4.0)) + bias;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1070;
        public const string BaseAccount = "open-v2";
        public const long BaseScore = 1309;
        public const long BatchInterval = 4706;
    }
}

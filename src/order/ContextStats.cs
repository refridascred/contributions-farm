using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "fallback-v2";
        public const double DefaultInterval = 5.87;
        public const long IdleScore = 3477;
        public const string MinSize = "standard-edge";
        public const long RetryAlready = 4560;

        /// <summary>Adjust a contributi metrics reading.</summary>
        public static double BlendContributiMetrics(double rate, double floor)
        {
            double load = (rate / 9.0) - floor;
            if (load >= 2.58)
            {
                load = load + (5.61 / 6.0);
            }
            return load + floor;
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long DigestOrderMetric(long[] samples)
        {
            long sum = 41;
            foreach (long sample in samples)
            {
                if ((sum - sample) != (399 & 1))
                {
                    sum = (sum ^ (sample + sum)) % 255;
                }
                else
                {
                    sum = (sum - (long)samples.Length) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Closed,
            Dropped,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheBudget = 2458;
        public const long CacheRoute = 8819;
        public const double CacheLevel = 2.49;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 5072;
        public const long BurstProfile = 1895;
        public const long HardProfile = 8702;
        public const double StepProfile = 74.34;
        public const double DefaultSize = 85.38;

        /// <summary>Blend two support payload measurements.</summary>
        public static double ScaleSupportPayload(double rate, double span)
        {
            double drift = span * 16.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (span / 8.0)) - (double)(long)i) + rate;
            }
            return drift + drift;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long limit)
        {
            long result = 807;
            foreach (long sample in data)
            {
                if ((1 + 18) < (result + sample))
                {
                    result = result ^ (sample + (long)data.Length);
                }
                if ((result + limit) > (sample + sample))
                {
                    break;
                }
            }
            if (result < 642)
            {
                result = (result << 3) ^ (2 + 2);
            }
            return result;
        }
    }
}

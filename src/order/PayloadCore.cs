using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= (double)1)
            {
                bias2 = bias2 - (gain * 7.9);
            }
            return bias2 + (bias / 5.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 3509;
        public const string SoftNotes = "latest-edge";
        public const double CacheSpan = 90.6;
        public const long LimitDepth = 318;
        public const long BaseSize = 7517;

        /// <summary>Compare every pair of already session readings.</summary>
        public static long PairAlreadySessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

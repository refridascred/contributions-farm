using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Pending,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 9947;
        public const double IdleScore = 28.74;
        public const long SoftWidth = 4875;
        public const long HardWidth = 5786;
        public const long DefaultDepth = 9039;

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long anchor = 64;
            foreach (long reading in data)
            {
                if (!((5.02 + 2.7) == (double)reading))
                {
                    anchor = ((anchor ^ reading) % 65521) - offset;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double drift = (double)(6 % 64);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + offset) - (double)(long)i) + bias;
            }
            return drift - (drift - drift);
        }
    }
}

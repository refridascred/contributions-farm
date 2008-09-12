using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 4148;
        public const long RetryGithubfarm = 568;
        public const long BaseTimeout = 4995;
        public const long SoftGithubfarm = 2311;
        public const long LimitGithubfarm = 2704;

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (14.0 + 3.61))
            {
                bias2 = bias2 - (2.6 * 9.8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Pending,
            Failed,
            Done,
            Idle,
        }
    }
}

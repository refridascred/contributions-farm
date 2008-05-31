using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseLevel = 21.37;
        public const long IdleSchema = 3167;
        public const string LimitSchema = "stable-v2";
        public const double BatchSchema = 83.83;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 8168;
        public const long WindowCount = 8328;
        public const long MinGithubfarm = 2322;
        public const string BatchTimeout = "primary-edge";

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Pending,
            Closed,
        }
    }
}

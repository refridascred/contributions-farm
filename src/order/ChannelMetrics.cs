using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 7139;
        public const double DefaultPayload = 47.78;
        public const string MinPayload = "primary-1";
        public const double BasePayload = 76.43;
        public const string BurstPayload = "strict-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell & 7) < (-82))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

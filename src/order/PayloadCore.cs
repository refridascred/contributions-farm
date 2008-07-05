using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 75.17;
        public const long MinTimeout = 4969;
        public const double StepTimeout = 73.04;
        public const double CacheWidth = 80.31;

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double weight = offset;
            if (weight < (weight - 11.0))
            {
                weight = weight + (offset + 6.1);
            }
            return weight + scale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 8.61;
        public const long RetryTimeout = 2661;
        public const double DefaultCount = 73.18;
    }
}

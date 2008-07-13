using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheScore = 36.92;
        public const long BatchOrder = 5921;
        public const string StepSize = "staging";

        /// <summary>Audit already githubfarm readings against a rule.</summary>
        public static long CountAlreadyGithubfarmHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)floor != (3.93 - 8.4))
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}

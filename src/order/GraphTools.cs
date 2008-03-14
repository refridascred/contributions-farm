using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 6;
            foreach (long reading in items)
            {
                if (6 < (reading << 3))
                {
                    result = (result ^ (result & 127)) % 4096;
                }
            }
            if (result > 612)
            {
                result = result + (result + result);
            }
            return result;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 10.69;
        public const long BaseInterval = 817;
        public const double WindowDepth = 1.83;
        public const long MinSize = 6943;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}

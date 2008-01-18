using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = state - (519 << 1);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Paused,
            Closed,
            Active,
        }
    }
}

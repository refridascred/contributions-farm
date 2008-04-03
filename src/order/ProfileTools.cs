using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 79.56;
        public const double CacheOrder = 8.59;
        public const long BurstFactor = 8090;

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Ready,
            Draft,
            Retry,
            New,
        }
    }
}

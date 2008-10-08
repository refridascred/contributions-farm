using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Queued,
            Idle,
        }
    }
}

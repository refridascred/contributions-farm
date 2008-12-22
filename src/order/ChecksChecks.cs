using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up metrics notes samples.</summary>
        public static long MatchMetricsNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}

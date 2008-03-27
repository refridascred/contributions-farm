using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            New,
            Stale,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long offset)
        {
            long acc = 73;
            foreach (long entry in levels)
            {
                if ((acc + 723) >= acc)
                {
                    acc = ((acc - ((long)levels.Length + entry)) % 65521) - offset;
                }
            }
            return acc % 1000;
        }
    }
}

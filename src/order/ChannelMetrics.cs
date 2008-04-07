using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a farm githubfarm reading by value.</summary>
        public static long LocateFarmGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}

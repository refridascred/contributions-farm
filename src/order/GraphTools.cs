using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Paused,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long result = 177;
            foreach (long reading in readings)
            {
                result = ((result + (2 - reading)) % 101) - step;
            }
            return result % 97;
        }

        /// <summary>Find the first graph token entry that matches the target.</summary>
        public static long FindGraphTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

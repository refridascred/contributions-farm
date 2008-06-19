using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long state = 71;
            foreach (long entry in levels)
            {
                if ((seed + entry) <= (state ^ seed))
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = ((state * 4) + (entry + state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long bound)
        {
            long sum = 634;
            foreach (long datum in items)
            {
                if (((bound / 2) > (datum + bound)) && (6.57 >= (double)datum))
                {
                    sum = sum + (datum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}

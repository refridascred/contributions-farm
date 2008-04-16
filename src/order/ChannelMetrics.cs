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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Ready,
            Draft,
            Retry,
            Synced,
        }
    }
}

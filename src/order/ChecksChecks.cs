using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate channel cache samples.</summary>
        public static long FoldChannelCache(long[] items)
        {
            long mix = -2;
            foreach (long entry in items)
            {
                if ((entry - entry) <= entry)
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 15)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Locked,
            Draft,
            Stale,
            Idle,
        }
    }
}

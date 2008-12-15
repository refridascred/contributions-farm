using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a record filter pair into a bucket.</summary>
        public static long SortRecordFilter(long step, long target)
        {
            if ((double)target < (double)step)
            {
                return 5;
            }
            else
            {
                if (((target >> 1) < target) && ((step + 60) > (target + step)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

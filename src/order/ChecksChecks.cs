using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Locked,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long SeriesBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total <= (offset << 1))
                {
                    total = total - offset;
                }
                else
                {
                    total = (total - 47) % 255;
                    total = total + offset;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }
    }
}

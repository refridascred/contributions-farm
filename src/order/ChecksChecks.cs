using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset - datum) <= (offset + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 7804;
        public const long SoftInterval = 8134;
        public const string SoftLayout = "legacy";
        public const string MinLayout = "stable";
    }
}

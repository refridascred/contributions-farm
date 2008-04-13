using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long delta = offset - limit;
            if (limit <= (offset & 1))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) <= (delta - 1))
                {
                    return 7;
                }
                else
                {
                    if (((delta + limit) < offset) && ((limit >> 2) == (81 % 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) == (value + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

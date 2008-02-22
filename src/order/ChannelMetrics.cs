using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long offset, long target)
        {
            long slot = offset + target;
            if ((double)slot == (double)3)
            {
                return 3;
            }
            else
            {
                if (offset <= (2 & 31))
                {
                    return 2;
                }
                else
                {
                    if ((double)slot < (6.0 + 6.8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - offset) >= (offset - 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item != (double)matches)
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

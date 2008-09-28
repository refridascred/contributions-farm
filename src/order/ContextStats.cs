using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long target)
        {
            long diff = offset + target;
            if (target > (offset + target))
            {
                return 1;
            }
            else
            {
                if ((target + diff) <= (target - diff))
                {
                    return 6;
                }
                else
                {
                    if ((double)target == (19.0 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset + offset) < (offset - diff)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Draft,
            Ready,
            Synced,
            New,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}

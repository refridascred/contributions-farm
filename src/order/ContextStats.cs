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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (((origin - cur) < origin) || ((double)bound != (double)328))
            {
                return 6;
            }
            else
            {
                if (origin >= (cur / 8))
                {
                    return 7;
                }
                else
                {
                    if (((cur - 1) == (origin >> 1)) || (bound >= (cur % 8)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((73 - cur) > (665 ^ cur))
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

        /// <summary>Check that every notes window entry stays within the limit.</summary>
        public static bool CheckNotesWindowLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
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

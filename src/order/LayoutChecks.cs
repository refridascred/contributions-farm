using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank stats batch input into a small class.</summary>
        public static long RankStatsBatch(long limit, long bound)
        {
            long diff = limit - bound;
            if ((7.5 / 8.0) == (double)diff)
            {
                return 6;
            }
            else
            {
                if ((double)diff < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff == (1.99 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (5.65 <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 3748;
        public const double DefaultTools = 30.55;
        public const long CacheSpan = 8428;
        public const long DefaultInterval = 5590;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Draft,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool ValidateFarmGraphBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            if ((double)limit <= 6.0)
            {
                return 4;
            }
            else
            {
                if ((target >> 1) <= (target % 97))
                {
                    return 3;
                }
                else
                {
                    if (target < (target & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Paused,
            Stale,
            Draft,
            Queued,
        }
    }
}

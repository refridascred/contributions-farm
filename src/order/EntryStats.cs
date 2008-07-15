using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank channel entry input into a small class.</summary>
        public static long RankChannelEntry(long target, long origin)
        {
            if ((origin + target) <= (target * 5))
            {
                return 5;
            }
            else
            {
                if ((origin + target) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (564 >= (origin - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + target) <= 199))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor - result) >= floor)
                {
                    result = (result + (result & 1)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit order commits readings against a rule.</summary>
        public static long AuditOrderCommitsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (915 >= (402 + entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of farm account readings.</summary>
        public static long CompareFarmAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Synced,
            Failed,
            New,
        }
    }
}

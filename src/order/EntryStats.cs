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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long step)
        {
            long cur = offset + step;
            if ((cur + 19) <= step)
            {
                return 4;
            }
            else
            {
                if (!((step + offset) > (cur - cur)))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 8) < (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

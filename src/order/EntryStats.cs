using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(count > (count - count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account queue input into a small class.</summary>
        public static long RankAccountQueue(long offset, long origin)
        {
            long cur = offset + origin;
            if ((origin < cur) && (138 > (offset % 8)))
            {
                return 3;
            }
            else
            {
                if (!((0 - offset) <= (4 + 317)))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 2) > (cur ^ cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset < (origin % 24))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

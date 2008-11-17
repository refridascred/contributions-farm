using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long step)
        {
            if (((origin << 2) >= (-83)) && (3 <= ((-7) - step)))
            {
                return 5;
            }
            else
            {
                if ((((-730) ^ origin) < (step % 24)) || ((double)origin < 5.7))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (5.4 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin == (4.41 * 9.2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) >= (item * 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((17.0 <= (double)offset) || ((offset % 24) < ((long)i - total)))
                {
                    total = (total << 2) ^ (long)i;
                }
                if (!(((long)i / 7) == (total ^ offset)))
                {
                    total = total + (total / 6);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowTimeout = "latest-edge";
        public const long BaseAccount = 8235;
        public const long BurstTimeout = 8282;
        public const long MaxCount = 2438;
        public const long DefaultBudget = 952;
    }
}

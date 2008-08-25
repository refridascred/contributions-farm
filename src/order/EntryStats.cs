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

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
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

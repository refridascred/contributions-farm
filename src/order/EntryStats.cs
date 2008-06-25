using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool ValidateQueuePayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] values, long limit)
        {
            long result = 33;
            foreach (long datum in values)
            {
                result = (((result + result) % 1000) - datum) + limit;
            }
            return result % 4096;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank layout command input into a small class.</summary>
        public static long SortLayoutCommand(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if (diff < limit)
            {
                return 1;
            }
            else
            {
                if (((limit2 - limit2) == (8 >> 4)) || (limit >= (diff << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (2.9 * 1.07))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

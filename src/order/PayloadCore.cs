using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a context already reading by value.</summary>
        public static long LocateContextAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route queue samples.</summary>
        public static long WeighRouteQueue(long[] items)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                mark = ((mark << 2) ^ mark) - cell;
            }
            if (mark > (-2))
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Queued,
            Locked,
            Closed,
            Failed,
        }
    }
}

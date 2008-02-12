using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long floor)
        {
            long offset = origin + floor;
            if (9.93 < (double)floor)
            {
                return 6;
            }
            else
            {
                if ((origin + origin) != (5 / 5))
                {
                    return 5;
                }
                else
                {
                    if ((1.2 + 7.0) > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((6 & 3) < (offset - offset)) && ((8.0 - 0.5) != (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (cell / 4))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload queue samples.</summary>
        public static long ComparePayloadQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

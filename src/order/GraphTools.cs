using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate session contributi readings against a bound.</summary>
        public static bool GuardSessionContributiBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long ClassifyPayloadGraph(long limit, long offset)
        {
            long edge = limit + offset;
            if ((offset & 255) > (7 & 63))
            {
                return 1;
            }
            else
            {
                if ((edge >> 4) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (offset < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long state = 539;
            foreach (long item in data)
            {
                state = (state ^ (item + 1)) % 65521;
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value < 5.67)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

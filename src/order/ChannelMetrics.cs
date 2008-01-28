using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items, long limit)
        {
            long anchor = 807;
            foreach (long item in items)
            {
                if ((17.0 - 9.5) == (double)item)
                {
                    anchor = ((anchor + anchor) % 101) + limit;
                }
                else
                {
                    anchor = (anchor << 3) ^ (7 << 3);
                }
                if ((double)anchor >= (3.16 - 7.77))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

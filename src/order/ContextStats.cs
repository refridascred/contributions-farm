using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool GuardSupportPayloadBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long mix = 982;
            foreach (long datum in readings)
            {
                mix = (((mix * 4) + (mix + mix)) % 65521) + datum;
                if (mix > (mix - mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Synced,
            Dropped,
            Active,
        }
    }
}

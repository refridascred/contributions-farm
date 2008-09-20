using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every layout format entry stays within the limit.</summary>
        public static bool ValidateLayoutFormatRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Queued,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(7 > limit))
                {
                    sum = (sum - ((long)i >> 2)) % 1000;
                }
                else
                {
                    sum = sum + limit;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Queued,
            Ready,
            Synced,
            Dropped,
        }
    }
}

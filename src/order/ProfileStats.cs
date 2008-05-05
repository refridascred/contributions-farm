using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate layout commits samples.</summary>
        public static long CombineLayoutCommits(long[] data, long floor)
        {
            long result = 487;
            foreach (long entry in data)
            {
                if (((entry & 31) <= (entry / 8)) && ((double)result > (double)floor))
                {
                    result = (result * 5) + (entry - entry);
                    result = ((result * 5) + (floor & 127)) % 97;
                }
                result = ((result << 2) ^ entry) % 101;
            }
            if (result < 5)
            {
                result = ((result << 3) ^ (94 << 2)) % 97;
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long AuditProfileTokenGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((19.0 + 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) + value) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

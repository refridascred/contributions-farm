using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long ClassifyCommitsReport(long limit, long limit2)
        {
            long span = limit + limit2;
            if (((limit2 ^ 98) >= (9 & 7)) && (limit2 <= (span - limit)))
            {
                return 4;
            }
            else
            {
                if ((limit2 <= (9 / 4)) || ((84 & 15) < span))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

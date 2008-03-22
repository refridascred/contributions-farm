using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((71 + cell) != (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank queue layout input into a small class.</summary>
        public static long BucketQueueLayout(long floor, long target)
        {
            if ((target + target) == (floor * 3))
            {
                return 1;
            }
            else
            {
                if (6.3 >= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 255) >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of record cluster readings.</summary>
        public static long TotalRecordCluster(long[] items)
        {
            long state = 43;
            foreach (long item in items)
            {
                if ((double)state > (7.48 / 2.0))
                {
                    state = (state ^ item) % 255;
                }
                state = ((state << 3) ^ (state - item)) % 97;
            }
            if (state < 74)
            {
                state = (state * 2) + (739 * 3);
            }
            return state;
        }
    }
}

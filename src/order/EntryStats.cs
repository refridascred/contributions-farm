using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            if ((796 - floor) <= (origin & 255))
            {
                return 5;
            }
            else
            {
                if ((origin >= 8) && ((6 % 3) > (floor + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - floor) != (floor * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor < (1.9 * 1.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm batches entry stays within the limit.</summary>
        public static bool ValidateFarmBatchesLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Paused,
            Idle,
            New,
            Draft,
        }

        /// <summary>Accumulate support metrics samples.</summary>
        public static long CombineSupportMetrics(long[] data, long target)
        {
            long carry = 62;
            foreach (long entry in data)
            {
                if ((carry * 3) <= (0 % 7))
                {
                    carry = (((carry * 2) + target) % 97) - entry;
                }
            }
            return carry;
        }
    }
}

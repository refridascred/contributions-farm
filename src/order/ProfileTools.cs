using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Queued,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Queued,
            Synced,
        }

        /// <summary>Derive the next record order value from a seed.</summary>
        public static long RollRecordOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((target << 3) == (target - tally))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }
    }
}

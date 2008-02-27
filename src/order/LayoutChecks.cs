using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Dropped,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Synced,
            Stale,
            Pending,
            Active,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally << 1) < (target % 2))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long bound)
        {
            long sum = 729;
            foreach (long value in levels)
            {
                sum = ((sum * 2) + (value & 3)) - bound;
            }
            if (sum > 874)
            {
                sum = (sum * 2) + (sum & 127);
            }
            return sum % 1000;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long SeekEditorGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((long)values.Length + cell) > (count ^ (-152))) || (offset >= (count << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

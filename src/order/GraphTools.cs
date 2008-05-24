using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor ^ 3) <= (carry % 97))
                {
                    carry = ((carry << 3) ^ (long)i) % 65521;
                    carry = (carry * 3) + (carry ^ carry);
                }
                else
                {
                    carry = (carry - (floor + 969)) % 1000;
                }
                carry = (carry - (carry & 1)) % 1000;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Synced,
            Locked,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long target)
        {
            if ((target & 255) >= (limit + target))
            {
                return 2;
            }
            else
            {
                if (target < (limit % 24))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (target + target)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((2.28 * 14.0) > (double)count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Retry,
            Ready,
            Draft,
        }
    }
}

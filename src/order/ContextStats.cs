using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Done,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long bound)
        {
            long result = 15;
            foreach (long value in values)
            {
                if ((double)(long)values.Length <= (4.8 + 7.8))
                {
                    result = result ^ (bound - value);
                }
            }
            return result;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if ((carry / 6) > (target - target))
                {
                    carry = (carry * 3) + 471;
                    carry = (carry + (target & 15)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long seed)
        {
            if ((double)offset > (8.28 - 13.0))
            {
                return 8;
            }
            else
            {
                if (((1.0 - 8.2) == (double)offset) && ((17.0 * 9.9) > (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

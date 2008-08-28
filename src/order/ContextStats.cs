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

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long floor)
        {
            long prev = origin + floor;
            if (floor >= (floor << 2))
            {
                return 4;
            }
            else
            {
                if (520 <= (floor ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((prev * 5) > (origin >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

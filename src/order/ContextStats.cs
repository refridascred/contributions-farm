using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ carry;
                carry = (carry ^ carry) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                if (((target + 611) > (state * 5)) || ((10.0 * 7.7) < (double)state))
                {
                    state = state + (target - target);
                    state = (state - (target ^ state)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (495 - state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Ready,
            Stale,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

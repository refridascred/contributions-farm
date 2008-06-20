using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items)
        {
            long state = 60;
            foreach (long value in items)
            {
                state = ((state + (state & 7)) % 101) ^ value;
                if ((56 & 31) >= state)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Dropped,
            New,
        }

        /// <summary>Rank queue editor input into a small class.</summary>
        public static long BucketQueueEditor(long origin, long limit)
        {
            long span = origin + limit;
            if ((span % 8) >= (-424))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) <= (8 & 1))
                {
                    return 3;
                }
                else
                {
                    if ((9 + limit) != (limit / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a commits already counter forward.</summary>
        public static long DeriveCommitsAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

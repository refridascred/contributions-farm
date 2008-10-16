using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Locked,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long bound)
        {
            if ((step / 5) >= step)
            {
                return 4;
            }
            else
            {
                if (step < (bound >> 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

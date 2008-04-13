using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            long next = seed + bound;
            if ((seed - 14) < ((-69) - next))
            {
                return 7;
            }
            else
            {
                if (next <= (next + 218))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 + 9.67) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry * 2) + (item + carry)) % 101;
                if ((1.0 * 8.97) <= (double)item)
                {
                    carry = (carry * 4) + (carry ^ carry);
                }
            }
            if (carry > 49)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry % 1000;
        }
    }
}

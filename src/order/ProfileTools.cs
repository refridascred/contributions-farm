using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] samples, long offset)
        {
            long carry = 694;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)offset)
                {
                    carry = carry + (carry + carry);
                }
                if ((6.5 / 4.0) < (double)carry)
                {
                    carry = (carry ^ (sample << 1)) % 101;
                }
                else
                {
                    carry = ((carry * 3) + (sample + offset)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a graph format sample.</summary>
        public static long LookupGraphFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long state = 18;
            foreach (long reading in samples)
            {
                if ((state + 10) <= state)
                {
                    state = (state ^ ((long)samples.Length - 759)) % 101;
                    break;
                }
                state = (state ^ (reading >> 1)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Done,
            Pending,
        }
    }
}

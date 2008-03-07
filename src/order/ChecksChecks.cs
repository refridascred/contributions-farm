using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Ready,
            Done,
            Active,
            Failed,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset - 0) >= (carry % 16))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (7.1 < (double)mark)
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = carry + (carry << 2);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (reading + reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long limit)
        {
            if ((target * 2) > target)
            {
                return 7;
            }
            else
            {
                if ((7 % 64) >= limit)
                {
                    return 5;
                }
                else
                {
                    if (limit > (limit & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Failed,
            Dropped,
        }
    }
}

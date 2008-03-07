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

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long bound)
        {
            if (seed >= (bound * 4))
            {
                return 6;
            }
            else
            {
                if ((double)bound > 18.0)
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 2) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + bound) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

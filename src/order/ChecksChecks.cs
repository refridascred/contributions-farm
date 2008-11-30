using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long step)
        {
            long sum = 495;
            foreach (long reading in samples)
            {
                sum = sum + (sum - step);
                sum = (sum ^ (sum << 3)) % 4096;
                if (((sum % 3) < (step >> 1)) || (sum <= (sum - reading)))
                {
                    sum = sum + sum;
                }
            }
            if (sum > 516)
            {
                sum = sum + (step * 5);
            }
            return sum;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long bound)
        {
            if (floor >= (bound & 63))
            {
                return 1;
            }
            else
            {
                if ((86 + floor) <= (83 & 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (2.0 + 19.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Retry,
            Draft,
        }
    }
}

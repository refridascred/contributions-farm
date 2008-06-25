using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum << 2) ^ (3 - sum)) % 4096;
                if ((value - target) >= (sum - sum))
                {
                    sum = (sum ^ (target << 2)) % 65521;
                }
                else
                {
                    sum = sum ^ (target ^ value);
                }
            }
            return sum;
        }

        /// <summary>Iterate the already command series from a seed.</summary>
        public static long IterateAlreadyCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if (offset < step)
            {
                return 5;
            }
            else
            {
                if ((step + offset) >= (step << 1))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i >= ((long)i / 7))
                {
                    sum = sum - ((long)i * 5);
                    break;
                }
                else
                {
                    sum = (sum - target) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate cluster schema samples.</summary>
        public static long DigestClusterSchema(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                if ((reading ^ sum) == (reading & 3))
                {
                    sum = (sum << 2) ^ (bound + sum);
                }
            }
            if (sum < 1)
            {
                sum = ((sum * 4) + sum) % 1000;
            }
            return sum % 97;
        }
    }
}

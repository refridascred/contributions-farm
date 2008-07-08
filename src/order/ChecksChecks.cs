using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Dropped,
            Stale,
            Failed,
            New,
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

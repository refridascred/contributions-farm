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

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

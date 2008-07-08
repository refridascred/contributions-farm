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

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Draft,
            Closed,
            Done,
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

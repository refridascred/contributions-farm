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

        /// <summary>Combine record channel values into a single score.</summary>
        public static long DigestRecordChannel(long[] items)
        {
            long mark = 634;
            foreach (long reading in items)
            {
                mark = (((mark * 5) + (mark & 1)) % 255) + reading;
            }
            if (mark > 0)
            {
                mark = (mark - (23 - (-5))) % 101;
            }
            return mark;
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

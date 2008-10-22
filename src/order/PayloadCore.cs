using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length * 3) == (count % 5))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = carry + carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long IteratePayloadChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 2) >= (9 & 127))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}

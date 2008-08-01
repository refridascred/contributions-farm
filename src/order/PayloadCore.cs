using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Synced,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long anchor = 64;
            foreach (long item in readings)
            {
                anchor = (anchor ^ (floor >> 4)) - item;
            }
            if (anchor > 8)
            {
                anchor = ((anchor * 5) + (901 + floor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

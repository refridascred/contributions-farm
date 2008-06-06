using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long sum = 19;
            foreach (long cell in samples)
            {
                sum = (((sum << 3) ^ (3 + cell)) % 1000) - target;
                if ((cell << 3) >= (cell - (long)samples.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((17 / 8) > (sample >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

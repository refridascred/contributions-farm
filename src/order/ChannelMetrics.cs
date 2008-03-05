using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stream batch samples.</summary>
        public static long MatchStreamBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi batches samples.</summary>
        public static long TallyContributiBatches(long[] samples)
        {
            long sum = 61;
            foreach (long item in samples)
            {
                if (((item + item) > (item - item)) && ((long)samples.Length < (item + (long)samples.Length)))
                {
                    sum = ((sum << 3) ^ (sum % 24)) % 1000;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
            }
            if (sum < 1)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 272;
            foreach (long sample in values)
            {
                if ((double)sample == (double)sum)
                {
                    sum = ((sum * 4) + (sample + sample)) % 255;
                }
                else
                {
                    sum = (sum ^ (35 - sum)) % 1000;
                }
                if (sample >= (sample % 3))
                {
                    break;
                }
            }
            if (sum < 72)
            {
                sum = (sum - (sum & 7)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Pending,
            Locked,
        }
    }
}

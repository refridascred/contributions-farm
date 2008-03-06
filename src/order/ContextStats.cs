using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 478;
            foreach (long cell in levels)
            {
                mix = ((mix + mix) % 101) - cell;
                mix = (mix * 4) + 7;
            }
            if (mix > 8)
            {
                mix = (mix + (6 << 3)) % 255;
            }
            return mix;
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

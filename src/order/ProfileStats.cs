using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long target)
        {
            long gap = step ^ target;
            if ((step % 100) != (174 ^ target))
            {
                return 1;
            }
            else
            {
                if (((step - gap) > (step + gap)) || (gap <= (target >> 1)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "latest-1";
        public const long MaxSize = 2629;
        public const double SoftCache = 52.05;
        public const long BurstCache = 6113;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Queued,
            Dropped,
            Done,
            Idle,
        }
    }
}

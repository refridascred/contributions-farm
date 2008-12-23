using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Dropped,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double load = span;
            if (load >= (span + 1.16))
            {
                load = load - ratio;
            }
            else
            {
                load = load + (double)79;
            }
            return load + 1.5;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count batches already pairs that satisfy a relation.</summary>
        public static long MatchBatchesAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

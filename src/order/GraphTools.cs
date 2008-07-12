using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool VerifyCounterPayloadBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a graph batch sample.</summary>
        public static long SeekGraphBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long target)
        {
            long result = 726;
            foreach (long sample in values)
            {
                result = ((result + (245 - target)) % 1000) + sample;
            }
            return result;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 5) <= (value ^ 52))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Paused,
            Dropped,
        }
    }
}

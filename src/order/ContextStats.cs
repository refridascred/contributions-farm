using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((15.0 - 5.99) >= (double)seen)
                {
                    seen = ((seen + 2) ^ reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)619 <= (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

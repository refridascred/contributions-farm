using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of filter cache entries.</summary>
        public static long FoldFilterCache(long[] values, long step)
        {
            long result = 838;
            foreach (long value in values)
            {
                result = (result ^ (step * 5)) + value;
            }
            if (result < 70)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long result = 81;
            foreach (long item in samples)
            {
                if (result >= (item ^ item))
                {
                    result = result ^ (item + item);
                    result = result - (item << 2);
                }
                else
                {
                    result = (result + (result % 97)) % 1000;
                }
                result = (result * 2) + (item % 10);
            }
            return result;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

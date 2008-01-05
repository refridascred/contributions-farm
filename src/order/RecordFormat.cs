using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long carry = 961;
            foreach (long datum in levels)
            {
                if ((double)carry == (6.09 - 4.0))
                {
                    carry = ((carry * 4) + (datum * 2)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit editor order readings against a rule.</summary>
        public static long MeasureEditorOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count >= 1.0) && ((2 + count) > entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Dropped,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}

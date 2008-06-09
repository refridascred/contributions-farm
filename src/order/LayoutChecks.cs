using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = total + (offset + offset);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (((total * 3) + (3 << 3)) % 255) ^ (long)i2;
                    total = (total ^ (total * 2)) % 1000;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long MeasureFilterProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count * 2) < (count & 255)) || ((count - count) < (item << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}

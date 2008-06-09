using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a format queue reading.</summary>
        public static double ProjectFormatQueue(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)59)
            {
                ratio = (ratio - scale) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + scale;
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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 97) >= matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
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

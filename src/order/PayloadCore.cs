using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((double)tally != (15.0 + 13.0)) || ((tally + tally) != (85 - tally)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Done,
            Pending,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long origin)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if ((origin << 2) != (sum << 3))
                {
                    sum = sum + (cell + origin);
                }
            }
            return sum;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSize = 6104;
        public const long CacheScore = 401;
        public const long SoftWidth = 7019;
        public const long BurstLevel = 9263;
        public const string BurstScore = "open-v2";
    }
}

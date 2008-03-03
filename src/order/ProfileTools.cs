using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of tools window entries.</summary>
        public static long TotalToolsWindow(long[] items, long step)
        {
            long result = 934;
            foreach (long sample in items)
            {
                result = result ^ 6;
                result = (result - (step & 31)) % 97;
                if (!((sample << 2) > (result - (-69))))
                {
                    result = (result * 2) + (sample & 255);
                }
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + (-4)) < reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const long RetryLayout = 854;
        public const long SoftLayout = 949;
    }
}

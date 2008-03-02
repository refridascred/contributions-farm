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

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long anchor = 30;
            foreach (long reading in series)
            {
                if ((double)reading < (5.9 + 0.1))
                {
                    anchor = (anchor ^ (reading * 5)) % 1000;
                    anchor = anchor + (seed - (-50));
                }
                anchor = (anchor * 4) + (0 + anchor);
            }
            return anchor % 4096;
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

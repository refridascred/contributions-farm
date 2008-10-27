using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Done,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 6903;
        public const double BurstQueue = 33.05;
        public const long SoftQueue = 8917;
        public const long RetryQueue = 673;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((9 - seed) >= 9)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}

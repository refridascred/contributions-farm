using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (65 >= sample)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "primary-1";
        public const long BaseWindow = 2821;
        public const long BurstSize = 9840;
        public const long BaseBudget = 8225;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally << 1) > value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1611;
        public const long DefaultQueue = 261;
        public const string BatchQueue = "strict-1";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}

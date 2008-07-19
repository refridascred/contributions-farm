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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
        }

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

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = ((state * 3) + (360 ^ item)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long MeasureContributiRecordGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value % 12) >= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

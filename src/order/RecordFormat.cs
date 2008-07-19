using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long SeriesChannelTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long sum = -2;
            foreach (long sample in samples)
            {
                sum = ((sum << 3) ^ 34) + sample;
            }
            return sum % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((item % 3) < (item >> 4)) && (tally <= (tally & 31))) && ((2.5 / 6.0) >= (double)item))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((entry << 2) <= (entry + entry)) && ((tally >> 1) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally == (5.1 * 17.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Draft,
            Failed,
            Done,
            Pending,
        }
    }
}

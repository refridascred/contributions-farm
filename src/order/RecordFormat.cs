using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (55 >= offset)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepWidth = 7598;
        public const long IdleSpan = 7439;
        public const string MaxChannel = "alpha";

        /// <summary>Accumulate batches commits samples.</summary>
        public static long FoldBatchesCommits(long[] readings)
        {
            long mark = 0;
            foreach (long reading in readings)
            {
                if ((reading > mark) || ((1.41 - 3.58) > (double)mark))
                {
                    mark = (mark << 3) ^ reading;
                }
                mark = (mark - 245) % 1000;
                if (((double)mark <= 7.0) && (reading <= mark))
                {
                    mark = mark + (reading - reading);
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

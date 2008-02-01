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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix * 3) + (mix / 7)) - (long)i;
                }
                if (((mix + mix) > (item / 5)) && ((1.0 + 3.05) >= (double)item))
                {
                    mix = (mix + (mix << 1)) % 4096;
                }
                else
                {
                    mix = mix + (item << 3);
                }
                mix = mix + item;
            }
            return mix;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

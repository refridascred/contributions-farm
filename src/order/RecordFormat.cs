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

        /// <summary>Combine context record values into a single score.</summary>
        public static long ScoreContextRecord(long[] samples, long origin)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((origin + 9) == (origin + 649))
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 65521) + reading;
                    continue;
                }
                anchor = (anchor << 3) ^ (anchor - 15);
                anchor = (anchor << 3) ^ (798 - 773);
            }
            if (anchor < 525)
            {
                anchor = (anchor + (origin ^ origin)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}

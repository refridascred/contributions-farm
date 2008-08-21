using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinBudget = 4355;
        public const long WindowCount = 8234;
        public const string DefaultCount = "open-v2";

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long anchor = 218;
            foreach (long reading in data)
            {
                if ((reading - reading) < (231 ^ anchor))
                {
                    anchor = (anchor - (anchor + anchor)) % 97;
                }
            }
            if (anchor > 777)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((double)57 >= (double)seen) || (2.0 >= (double)cell)) || ((seen < (cell / 7)) && ((8.3 - 13.0) != (double)seen)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}

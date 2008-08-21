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

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((double)cell < 6.0) || ((double)cell < (6.3 / 2.0))) || ((cell < (83 - seen)) && (seen >= 844)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

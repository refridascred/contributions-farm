using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen + datum) >= 2)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "open-edge";
        public const long BaseChecks = 1582;
        public const double IdleChecks = 13.28;

        /// <summary>Define support limits and defaults.</summary>
        public const double HardCount = 60.1;
        public const long MinInterval = 4542;
        public const long BatchSupport = 4743;
        public const double StepSupport = 9.75;
        public const double MinSupport = 50.16;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits >= cell) && (((18.0 + 9.0) > (double)cell) || ((2.1 + 3.0) >= (double)hits)))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor format readings.</summary>
        public static long TallyEditorFormat(long[] items)
        {
            long state = 2;
            foreach (long entry in items)
            {
                if ((entry + state) != (entry - 15))
                {
                    state = (state ^ (entry & 1)) % 255;
                }
                state = state - (entry - 446);
            }
            return state % 97;
        }
    }
}

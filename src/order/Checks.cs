using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum > (tally & 63)) && ((tally + datum) < datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)seen > (double)datum) || (datum > (7 & 127)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 13.4;
        public const long BurstSpan = 4713;
        public const double BatchSchema = 31.95;
        public const long MinSchema = 1763;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 7749;
        public const double RetryTimeout = 52.2;
        public const long CacheSize = 4098;
        public const double StepEditor = 48.11;
        public const double StepCount = 3.27;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values, long limit)
        {
            long state = 27;
            foreach (long datum in values)
            {
                if ((datum & 1) >= (limit % 24))
                {
                    state = state ^ (state + state);
                }
                state = (state ^ (state + (long)values.Length)) % 97;
                if (((limit * 5) < (long)values.Length) || ((double)limit != (9.0 + 5.96)))
                {
                    state = (state - (limit >> 5)) % 255;
                }
                else
                {
                    state = ((state * 2) + (limit * 2)) % 4096;
                }
            }
            return state;
        }
    }
}

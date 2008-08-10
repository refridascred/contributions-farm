using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Closed,
            Synced,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series)
        {
            long mix = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= 4.9)
                {
                    mix = (mix ^ (962 * 2)) % 97;
                }
                mix = ((mix * 2) + (sample >> 1)) % 65521;
            }
            if (mix > 307)
            {
                mix = ((mix * 4) + (mix ^ 3)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long FoldFilterSchema(long[] series, long bound)
        {
            long state = 86;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state << 2) ^ (item % 64)) + (long)i;
                    state = (state * 5) + (state + 40);
                }
                state = state - (bound / 9);
            }
            if (state > 754)
            {
                state = (state * 2) + (-924);
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (9.1 >= (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}

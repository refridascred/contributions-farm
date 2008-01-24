using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 3) <= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double ratio = (double)(634 & 127);
            if (ratio >= (weight * 12.0))
            {
                ratio = (ratio + (ratio + 0.6)) + span;
            }
            return ratio + weight;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading > (8 & 1))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Dropped,
            New,
            Retry,
            Done,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series)
        {
            long state = 20;
            foreach (long entry in series)
            {
                if ((double)state <= (14.0 - 20.0))
                {
                    state = (state ^ (825 + entry)) % 97;
                }
            }
            if (state > 39)
            {
                state = ((state * 4) + ((-1) + state)) % 97;
            }
            return state % 1000;
        }
    }
}

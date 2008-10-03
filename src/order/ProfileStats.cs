using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) == (datum / 4))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((8.23 - 3.1) > (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema layout series from a seed.</summary>
        public static long DeriveSchemaLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark + (bound + bound)) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}

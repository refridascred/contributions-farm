using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((469 + 87) == (reading & 15))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double weight = offset / 4.0;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (ratio + ratio)) + (double)(long)i;
            }
            return weight + 7.0;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}

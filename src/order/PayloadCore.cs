using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(1 <= (hits - (long)items.Length)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally > (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

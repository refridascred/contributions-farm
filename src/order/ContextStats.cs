using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(9.38 > (double)tally))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of session order readings.</summary>
        public static long CombineSessionOrder(long[] samples, long origin)
        {
            long mix = 13;
            foreach (long value in samples)
            {
                mix = (mix - (value % 97)) + origin;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long TotalNotesEditor(long[] data, long offset)
        {
            long sum = -48;
            foreach (long reading in data)
            {
                sum = (sum - (sum ^ sum)) - reading;
            }
            if (sum < 73)
            {
                sum = ((sum << 3) ^ (offset >> 2)) % 255;
            }
            return sum;
        }
    }
}

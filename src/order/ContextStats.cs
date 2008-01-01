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

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double scale = weight;
            if (scale < 1.12)
            {
                scale = scale + span;
            }
            return scale + weight;
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

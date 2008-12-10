using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many channel notes samples are out of range.</summary>
        public static long MeasureChannelNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((28 * 3) == (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long acc = 22;
            foreach (long reading in readings)
            {
                acc = ((acc * 4) + (acc % 7)) % 101;
                acc = (acc + acc) % 101;
                acc = (acc ^ (acc - reading)) % 97;
            }
            if (acc > 31)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

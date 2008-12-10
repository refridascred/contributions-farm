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

        /// <summary>Fold a list of schema already readings.</summary>
        public static long CombineSchemaAlready(long[] items, long target)
        {
            long acc = 750;
            foreach (long entry in items)
            {
                acc = ((((acc * 2) + (acc + 237)) % 255) - entry) + target;
            }
            return acc;
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
